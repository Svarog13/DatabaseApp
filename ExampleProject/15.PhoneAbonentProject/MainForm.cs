using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _15.PhoneAbonentProject.Classes;
using _15.PhoneAbonentProject.Servises;

namespace _15.PhoneAbonentProject
{
    public partial class MainForm : Form
    {
        private readonly AbonentManager abonentManager;
        private AddAbonentForm addAbonentForm;

        public MainForm()
        {
            InitializeComponent();
            abonentManager = new AbonentManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
     
        }

        private void btnAddAbonent_Click(object sender, EventArgs e)
        {
            addAbonentForm = new AddAbonentForm(); // Fixed variable assignment

            DialogResult result = addAbonentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Subscriber newSubscriber = addAbonentForm.GetSubscriberDetails();
                abonentManager.AddSubscriber(newSubscriber);

                RefreshSubscribersList(); // Fixed method name
            }
        }

        private void btnShowAbonentInfo_Click(object sender, EventArgs e)
        {
            if (dgvAbonents.SelectedRows.Count > 0)
            {
                string subscriberName = dgvAbonents.SelectedRows[0].Cells["ColName"].Value.ToString();
                Subscriber selectedSubscriber = abonentManager.GetSubscribers().FirstOrDefault(s => s.Name == subscriberName);
                selectedSubscriber?.ShowSubscriberInfo();
            }
        }

        private void btnChangeTariff_Click(object sender, EventArgs e)
        {
            if (dgvAbonents.SelectedRows.Count > 0)
            {
                string subscriberName = dgvAbonents.SelectedRows[0].Cells["ColName"].Value.ToString();
                Subscriber selectedSubscriber = abonentManager.GetSubscribers().FirstOrDefault(s => s.Name == subscriberName);
                ChangeTariffForm changeTariffForm = new ChangeTariffForm(selectedSubscriber);
                DialogResult result = changeTariffForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TariffPlan updatedTariffPlan = changeTariffForm.GetUpdatedTariffPlan();
                    selectedSubscriber.TariffPlan = updatedTariffPlan;
                    RefreshSubscribersList();
                }
            }
        }

        private void btnDeleteAbonent_Click(object sender, EventArgs e)
        {
            if (dgvAbonents.SelectedRows.Count > 0)
            {
                string subscriberName = dgvAbonents.SelectedRows[0].Cells["ColName"].Value.ToString();
                Subscriber selectedSubscriber = abonentManager.GetSubscribers().FirstOrDefault(s => s.Name == subscriberName);
                abonentManager.RemoveSubscriber(selectedSubscriber?.Id ?? 0);
                RefreshSubscribersList();
            }
        }

        private void RefreshSubscribersList() // Fixed method name
        {
            dgvAbonents.Rows.Clear();

            foreach (var subscriber in abonentManager.GetSubscribers())
            {
                dgvAbonents.Rows.Add(subscriber.Name);
            }
        }
    }
}