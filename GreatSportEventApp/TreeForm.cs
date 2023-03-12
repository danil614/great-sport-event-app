﻿using GreatSportEventApp.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class TreeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {

        }

        private void MainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (MainTreeView.SelectedNode == null)
            {
                CreateToolStripMenuItem.Enabled = false;
                EditToolStripMenuItem.Enabled   = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                CreateToolStripMenuItem.Enabled = true;
                EditToolStripMenuItem.Enabled   = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
        }

        #region Операции с базой данных

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (MainTreeView.SelectedNode != null && MainTreeView.SelectedNode.Level == 1)
            {

            }
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            //using (var connection = new MySqlConnection(DatabaseConnection.GetConnectionString()))
            //{
                //connection.Open();
                using (var context = new GreatSportEventContext())
                {
                    //context.
                    var sportEvents = context.SportEvents;

                    foreach (var sportEvent in sportEvents)
                    {
                        MainTreeView.Nodes.Add(sportEvent.ToString());
                    }
                }
            //}
        }

        #endregion
    }
}