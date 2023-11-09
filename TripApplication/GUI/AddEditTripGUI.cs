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
    public partial class AddEditTripGUI : Form
    {
        private TripDTO trip;
        private readonly TripContext context = new TripContext();
        private static List<SlotDTO> slots = new List<SlotDTO>
        {
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
        public AddEditTripGUI()
        {
            InitializeComponent();
            LoadComboBox();
        }
        public AddEditTripGUI(TripDTO trip)
        {
            this.trip = trip;
            InitializeComponent();
            LoadComboBox();
            LoadTripData();
        }

        private void LoadComboBox()
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM/dd/yyyy";
            dtpDate.Value = DateTime.Now;

            cboSlot.DataSource = slots;
            cboSlot.DisplayMember = "SlotName";
            cboSlot.ValueMember = "SlotId";
            cboSlot.SelectedIndex = 0;

            cboLimo.DataSource = context.Limousines.ToList();
            cboLimo.DisplayMember = "Plate";
            cboLimo.ValueMember = "LimousineId";
            cboLimo.SelectedIndex = 0;
            cboLimo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLimo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboTrip.DataSource = context.Routes.ToList();
            cboTrip.DisplayMember = "RouteName";
            cboTrip.ValueMember = "RouteId";
            cboTrip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTrip.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (this.trip == null)
            {
                labelTitle.Text = "ADD NEW TRIP";
                dtpDate.Value = DateTime.Now;
            }
        }

        private void CheckLimo(int routeId, DateTime date, int slot, List<Limousine> listLimo)
        {
            Trip t = context.Trips.FirstOrDefault(t => t.RouteId == routeId && t.Date == date && t.Slot == slot);
            if (t != null)
            {
                int Id = (int)t.LimousineId;
                Limousine limo = listLimo.FirstOrDefault(l => l.LimousineId == Id);
                if (limo != null)
                {
                    listLimo.Remove(limo);
                }
            }
            cboLimo.DataSource = listLimo;
            cboLimo.DisplayMember = "Plate";
            cboLimo.ValueMember = "LimousineId";
            cboLimo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLimo.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void CheckSlot(int routeId, DateTime date, int limoId, List<SlotDTO> listSlot)
        {
            Trip t = context.Trips.FirstOrDefault(t => t.RouteId == routeId && t.Date == date && t.LimousineId == limoId);
            if (t != null)
            {
                int slot = (int)t.Slot;
                listSlot.RemoveAt(slot);
            }
            cboSlot.DataSource = slots;
            cboSlot.DisplayMember = "SlotName";
            cboSlot.ValueMember = "SlotId";
        }

        private void CalculatePrice(int routeId)
        {
            double price = 0;
            Route route = context.Routes.FirstOrDefault(r => r.RouteId == routeId);
            //Limousine limo = context.Limousines.FirstOrDefault(l => l.LimousineId == trip.LimousineId);
            if (route != null)
            {
                price = (double)(route.Distance * 1);
                
            }
            numPrice.Value = (Decimal)price;

        }

        //============================================================

        private void LoadTripData()
        {
            dtpDate.Enabled = false;
            dtpDate.Value = DateTime.Parse(trip.Date.ToString());
            cboLimo.SelectedItem = context.Limousines.Where(l => l.Plate == trip.LimousinePlate).FirstOrDefault();
            numPrice.Value = Decimal.Parse(trip.Price + "");
            cboSlot.SelectedValue = (int)trip.Slot;
            cboTrip.SelectedItem = context.Trips.FirstOrDefault(t => t.Route.RouteName == trip.TripName);
            cboTrip.Enabled = false;
        }

        private void cboTrip_Leave(object sender, EventArgs e)
        {
            Route r = context.Routes.FirstOrDefault(r => r.RouteName == cboTrip.Text);
            if (r == null)
            {
                MessageBox.Show("This trip does not exist", "ERROR");
                cboTrip.SelectedIndex = 0;
            }
            else
            {
                CheckLimo(int.Parse(cboTrip.SelectedValue.ToString()), dtpDate.Value, int.Parse(cboSlot.SelectedValue.ToString()), context.Limousines.ToList());
                CalculatePrice(int.Parse(cboTrip.SelectedValue.ToString()));
            }

        }

        private void cboLimo_Leave(object sender, EventArgs e)
        {
            Limousine limo = context.Limousines.FirstOrDefault(l => l.Plate == cboLimo.Text);
            if (limo == null)
            {
                MessageBox.Show("This Limousine does not exist", "ERROR");
                cboLimo.SelectedIndex = 0;
            }
            else
            {
                CalculatePrice(int.Parse(cboTrip.SelectedValue.ToString()));
            }
        }

        private void numPrice_Leave(object sender, EventArgs e)
        {
            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than 0", "ERROR");
                numPrice.Value = 1;
            }
        }

        private void dtpDate_Leave(object sender, EventArgs e)
        {
            CheckLimo(int.Parse(cboTrip.SelectedValue.ToString()), dtpDate.Value, int.Parse(cboSlot.SelectedValue.ToString()), context.Limousines.ToList());
        }

        private void cboSlot_Leave(object sender, EventArgs e)
        {
            CheckLimo(int.Parse(cboTrip.SelectedValue.ToString()), dtpDate.Value, int.Parse(cboSlot.SelectedValue.ToString()), context.Limousines.ToList());
        }
    }
}
