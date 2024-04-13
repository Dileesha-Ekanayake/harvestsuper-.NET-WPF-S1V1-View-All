using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace S1V1
{
    partial class EmployeeUi : Form
    {
        private DataGridView tblEmployee;

        public EmployeeUi()
        {
            InitializeComponent();
            List<Employee> employees = EmployeeController.Get();
            FillTable(employees);
        }

        private void FillTable(List<Employee> employees)
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("NIC", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Designation", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            // Add rows to the DataTable
            foreach (Employee emp in employees)
            {
                dataTable.Rows.Add(emp.Id,emp.Name,emp.Nic,emp.Gender.Name,emp.Designation.Name,emp.Employeestatus.Name);
            }

            // Initialize Panel and DataGridView
            //tableLayoutPanel1.Dock = DockStyle.Fill;
            Controls.Add(tableLayoutPanel1);

            tblEmployee = new DataGridView();
            tblEmployee.Dock = DockStyle.Fill;
            tblEmployee.DataSource = dataTable;
            tableLayoutPanel1.Controls.Add(tblEmployee);

            // Enable scrolling
            tableLayoutPanel1.AutoScroll = true;
        }
    }
}
