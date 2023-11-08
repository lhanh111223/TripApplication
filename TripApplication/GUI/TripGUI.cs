using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripApplication.DTO;
using TripApplication.Models;

namespace TripApplication.GUI
{
    public partial class TripGUI : Form
    {
        private readonly TripContext context = new TripContext();
        private string role;
        private static List<SlotDTO> slots = new List<SlotDTO>
        {
            new SlotDTO
            {
                SlotId = 0,
                SlotName = "All",
            },
            new SlotDTO
            {
                SlotId = 1,
                SlotName = "Day - 09:00:00 AM"
            },
            new SlotDTO
            {
                SlotId = 2,
                SlotName = "Night - 21:00:00 PM"
            }
        };
        public TripGUI()
        {
            InitializeComponent();
            LoadTripData();
            LoadComboBox();
        }

        public TripGUI(string role)
        {
            this.role = role;
            InitializeComponent();
            LoadTripData();
            LoadComboBox();
        }

        private void LoadTripData()
        {
            List<TripDTO> listTrip = GetListTripDTO();
            tripDataView.DataSource = listTrip;
            HideColumns();
            AddColumns();
        }

        private List<TripDTO> GetListTripDTO()
        {
            List<TripDTO> listTrip = (
                from trip in context.Trips.Include(t => t.Route).Include(t => t.Limousine).ToList()
                select new TripDTO
                {
                    TripId = trip.TripId,
                    TripName = trip.Route.RouteName,
                    TripFrom = trip.Route.RouteFrom,
                    TripTo = trip.Route.RouteTo,
                    Date = trip.Date,
                    Slot = trip.Slot,
                    Price = trip.Price,
                    LimousinePlate = trip.Limousine.Plate,
                    LimousineType = trip.Limousine.Type == 1 ? "NORMAL" : "VIP",
                    Status = trip.Status,
                }
                ).ToList();
            return listTrip;
        }

        private void RefreshTripDataView()
        {
            tripDataView.Columns.Clear();
            tripDataView.DataSource = null;
        }


        private void HideColumns()
        {
            tripDataView.Columns["TripFrom"].Visible = false;
            tripDataView.Columns["TripTo"].Visible = false;
            tripDataView.Columns["TripId"].Visible = false;
            tripDataView.Columns["Status"].Visible = false;
        }

        private void AddColumns()
        {
            tripDataView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Bookings",
                Text = "Bookings",
                UseColumnTextForButtonValue = true
            });
            if (this.role == "admin")
            {
                tripDataView.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                });
                tripDataView.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        //=============================================================================================


        //==============================================================================================

        private void LoadComboBox()
        {
            List<Location> listLocation = context.Locations.ToList();

            cboFrom.DataSource = new List<Location>(listLocation);
            cboFrom.DisplayMember = "LocationName";
            cboFrom.ValueMember = "LocationCode";
            cboFrom.SelectedIndex = 0;
            cboFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboFrom.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboTo.DataSource = new List<Location>(listLocation);
            cboTo.DisplayMember = "LocationName";
            cboTo.ValueMember = "LocationCode";
            cboTo.SelectedIndex = 1;
            cboTo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboTo.AutoCompleteSource = AutoCompleteSource.ListItems;


            cboSlot.DataSource = slots;
            cboSlot.DisplayMember = "SlotName";
            cboSlot.ValueMember = "SlotId";
            cboSlot.SelectedIndex = 0;

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM/dd/yyyy";
            dtpDate.Value = DateTime.Now;

            radioAll.Checked = true;
        }

        private void tripDataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labelNum.Text = $"The number of trips:  {tripDataView.Rows.Count}";
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            Location from = (Location)cboFrom.SelectedItem;
            Location to = (Location)cboTo.SelectedItem;

            List<TripDTO> listTrip = GetListTripDTO();
            listTrip = listTrip.Where(t => t.TripFrom == from.LocationCode && t.TripTo == to.LocationCode
            && t.Date == DateTime.Parse(dtpDate.Value.ToString("MM/dd/yyyy")))
                .ToList();

            if ((int)cboSlot.SelectedValue == 0)
            {

            }
            else
            {
                listTrip = listTrip.Where(t => t.Slot == (int)cboSlot.SelectedValue).ToList();
            }

            if (GetTypeChoosen() == "ALL")
            {

            }
            else
            {
                listTrip = listTrip.Where(t => t.LimousineType == GetTypeChoosen()).ToList();
            }

            RefreshTripDataView();
            tripDataView.DataSource = listTrip;
            HideColumns();
            AddColumns();

        }

        private string GetTypeChoosen()
        {
            if (radioNormal.Checked) return "NORMAL";
            if (radioVip.Checked) return "VIP";

            return "ALL";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshTripDataView();
            LoadTripData();
        }

        private void tripDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tripDataView.Rows[e.RowIndex];
            cboFrom.SelectedItem = context.Locations.Where(l => l.LocationCode == row.Cells["TripFrom"].Value).FirstOrDefault();
            cboTo.SelectedItem = context.Locations.Where(l => l.LocationCode == row.Cells["TripTo"].Value).FirstOrDefault();
            cboSlot.SelectedIndex = int.Parse(row.Cells["Slot"].Value.ToString());
            dtpDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            radioNormal.Checked = radioNormal.Text == row.Cells["LimousineType"].Value.ToString();
            radioVip.Checked = radioVip.Text == row.Cells["LimousineType"].Value.ToString();
        }
    }
}
