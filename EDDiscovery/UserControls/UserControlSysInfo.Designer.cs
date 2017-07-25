﻿/*
 * Copyright © 2016 - 2017 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
namespace EDDiscovery.UserControls
{
    partial class UserControlSysInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEDSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEDSMDownLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVisits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBody = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDistanceFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSystemState = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGameMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTravel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxBody = new ExtendedControls.TextBoxBorder();
            this.labelBodyName = new System.Windows.Forms.Label();
            this.textBoxPosition = new ExtendedControls.TextBoxBorder();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxVisits = new ExtendedControls.TextBoxBorder();
            this.labelVisits = new System.Windows.Forms.Label();
            this.labelAllegiance = new System.Windows.Forms.Label();
            this.labelEconomy = new System.Windows.Forms.Label();
            this.textBoxAllegiance = new ExtendedControls.TextBoxBorder();
            this.textBoxGovernment = new ExtendedControls.TextBoxBorder();
            this.labelGov = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxEconomy = new ExtendedControls.TextBoxBorder();
            this.textBoxState = new ExtendedControls.TextBoxBorder();
            this.buttonEDDB = new ExtendedControls.DrawnPanel();
            this.buttonRoss = new ExtendedControls.DrawnPanel();
            this.textBoxHomeDist = new ExtendedControls.TextBoxBorder();
            this.labelHomeDist = new System.Windows.Forms.Label();
            this.buttonEDSM = new ExtendedControls.DrawnPanel();
            this.textBoxSolDist = new ExtendedControls.TextBoxBorder();
            this.labelSolDist = new System.Windows.Forms.Label();
            this.toolTipEddb = new System.Windows.Forms.ToolTip(this.components);
            this.labelNote = new System.Windows.Forms.Label();
            this.richTextBoxNote = new ExtendedControls.RichTextBoxScroll();
            this.labelTarget = new System.Windows.Forms.Label();
            this.buttonEDSMTarget = new ExtendedControls.DrawnPanel();
            this.textBoxTarget = new ExtendedControls.AutoCompleteTextBox();
            this.textBoxTargetDist = new ExtendedControls.TextBoxBorder();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxSystem = new ExtendedControls.TextBoxBorder();
            this.labelSysName = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelGamemode = new System.Windows.Forms.Label();
            this.labelTravel = new System.Windows.Forms.Label();
            this.textBoxGameMode = new ExtendedControls.TextBoxBorder();
            this.textBoxTravelDist = new ExtendedControls.TextBoxBorder();
            this.textBoxTravelTime = new ExtendedControls.TextBoxBorder();
            this.textBoxTravelJumps = new ExtendedControls.TextBoxBorder();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxCargo = new ExtendedControls.TextBoxBorder();
            this.textBoxMaterials = new ExtendedControls.TextBoxBorder();
            this.labelMaterials = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSystem,
            this.toolStripEDSM,
            this.toolStripEDSMDownLine,
            this.toolStripVisits,
            this.toolStripBody,
            this.toolStripPosition,
            this.toolStripDistanceFrom,
            this.toolStripSystemState,
            this.toolStripNotes,
            this.toolStripTarget,
            this.toolStripGameMode,
            this.toolStripTravel,
            this.toolStripCargo});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(253, 290);
            // 
            // toolStripSystem
            // 
            this.toolStripSystem.Checked = true;
            this.toolStripSystem.CheckOnClick = true;
            this.toolStripSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSystem.Name = "toolStripSystem";
            this.toolStripSystem.Size = new System.Drawing.Size(252, 22);
            this.toolStripSystem.Text = "Display System Name";
            this.toolStripSystem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // toolStripEDSM
            // 
            this.toolStripEDSM.Checked = true;
            this.toolStripEDSM.CheckOnClick = true;
            this.toolStripEDSM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEDSM.Name = "toolStripEDSM";
            this.toolStripEDSM.Size = new System.Drawing.Size(252, 22);
            this.toolStripEDSM.Text = "Display EDSM Buttons";
            this.toolStripEDSM.Click += new System.EventHandler(this.toolStripEDSM_Click);
            // 
            // toolStripEDSMDownLine
            // 
            this.toolStripEDSMDownLine.Checked = true;
            this.toolStripEDSMDownLine.CheckOnClick = true;
            this.toolStripEDSMDownLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEDSMDownLine.Name = "toolStripEDSMDownLine";
            this.toolStripEDSMDownLine.Size = new System.Drawing.Size(252, 22);
            this.toolStripEDSMDownLine.Text = "EDSM buttons on separate line";
            this.toolStripEDSMDownLine.Click += new System.EventHandler(this.toolStripEDSMButtons_Click);
            // 
            // toolStripVisits
            // 
            this.toolStripVisits.Checked = true;
            this.toolStripVisits.CheckOnClick = true;
            this.toolStripVisits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripVisits.Name = "toolStripVisits";
            this.toolStripVisits.Size = new System.Drawing.Size(252, 22);
            this.toolStripVisits.Text = "Display Visits";
            this.toolStripVisits.Click += new System.EventHandler(this.toolStripVisits_Click);
            // 
            // toolStripBody
            // 
            this.toolStripBody.Checked = true;
            this.toolStripBody.CheckOnClick = true;
            this.toolStripBody.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripBody.Name = "toolStripBody";
            this.toolStripBody.Size = new System.Drawing.Size(252, 22);
            this.toolStripBody.Text = "Display Body Name";
            this.toolStripBody.Click += new System.EventHandler(this.toolStripBody_Click);
            // 
            // toolStripPosition
            // 
            this.toolStripPosition.Checked = true;
            this.toolStripPosition.CheckOnClick = true;
            this.toolStripPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripPosition.Name = "toolStripPosition";
            this.toolStripPosition.Size = new System.Drawing.Size(252, 22);
            this.toolStripPosition.Text = "Display Position";
            this.toolStripPosition.Click += new System.EventHandler(this.toolStripPosition_Click);
            // 
            // toolStripDistanceFrom
            // 
            this.toolStripDistanceFrom.Checked = true;
            this.toolStripDistanceFrom.CheckOnClick = true;
            this.toolStripDistanceFrom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripDistanceFrom.Name = "toolStripDistanceFrom";
            this.toolStripDistanceFrom.Size = new System.Drawing.Size(252, 22);
            this.toolStripDistanceFrom.Text = "Display Distance From";
            this.toolStripDistanceFrom.Click += new System.EventHandler(this.enableDistanceFromToolStripMenuItem_Click);
            // 
            // toolStripSystemState
            // 
            this.toolStripSystemState.Checked = true;
            this.toolStripSystemState.CheckOnClick = true;
            this.toolStripSystemState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSystemState.Name = "toolStripSystemState";
            this.toolStripSystemState.Size = new System.Drawing.Size(252, 22);
            this.toolStripSystemState.Text = "Display System State";
            this.toolStripSystemState.Click += new System.EventHandler(this.toolStripSystemState_Click);
            // 
            // toolStripNotes
            // 
            this.toolStripNotes.Checked = true;
            this.toolStripNotes.CheckOnClick = true;
            this.toolStripNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripNotes.Name = "toolStripNotes";
            this.toolStripNotes.Size = new System.Drawing.Size(252, 22);
            this.toolStripNotes.Text = "Display Notes";
            this.toolStripNotes.Click += new System.EventHandler(this.toolStripNotes_Click);
            // 
            // toolStripTarget
            // 
            this.toolStripTarget.Checked = true;
            this.toolStripTarget.CheckOnClick = true;
            this.toolStripTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripTarget.Name = "toolStripTarget";
            this.toolStripTarget.Size = new System.Drawing.Size(252, 22);
            this.toolStripTarget.Text = "Display Target";
            this.toolStripTarget.Click += new System.EventHandler(this.toolStripTarget_Click);
            // 
            // toolStripGameMode
            // 
            this.toolStripGameMode.Checked = true;
            this.toolStripGameMode.CheckOnClick = true;
            this.toolStripGameMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripGameMode.Name = "toolStripGameMode";
            this.toolStripGameMode.Size = new System.Drawing.Size(252, 22);
            this.toolStripGameMode.Text = "Display Game Mode";
            this.toolStripGameMode.Click += new System.EventHandler(this.toolStripGameMode_Click);
            // 
            // toolStripTravel
            // 
            this.toolStripTravel.Checked = true;
            this.toolStripTravel.CheckOnClick = true;
            this.toolStripTravel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripTravel.Name = "toolStripTravel";
            this.toolStripTravel.Size = new System.Drawing.Size(252, 22);
            this.toolStripTravel.Text = "Display Travel Trip Statistics";
            this.toolStripTravel.Click += new System.EventHandler(this.toolStripTravel_Click);
            // 
            // toolStripCargo
            // 
            this.toolStripCargo.Checked = true;
            this.toolStripCargo.CheckOnClick = true;
            this.toolStripCargo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripCargo.Name = "toolStripCargo";
            this.toolStripCargo.Size = new System.Drawing.Size(252, 22);
            this.toolStripCargo.Text = "Display Cargo and Material Count";
            this.toolStripCargo.Click += new System.EventHandler(this.toolStripCargo_Click);
            // 
            // textBoxBody
            // 
            this.textBoxBody.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxBody.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxBody.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxBody.BorderColorScaling = 0.5F;
            this.textBoxBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBody.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxBody.Location = new System.Drawing.Point(52, 75);
            this.textBoxBody.Multiline = false;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ReadOnly = true;
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxBody.SelectionLength = 0;
            this.textBoxBody.SelectionStart = 0;
            this.textBoxBody.Size = new System.Drawing.Size(152, 20);
            this.textBoxBody.TabIndex = 3;
            this.textBoxBody.TabStop = false;
            this.textBoxBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxBody.WordWrap = true;
            this.textBoxBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxBody.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelBodyName
            // 
            this.labelBodyName.AutoSize = true;
            this.labelBodyName.Location = new System.Drawing.Point(3, 77);
            this.labelBodyName.Name = "labelBodyName";
            this.labelBodyName.Size = new System.Drawing.Size(31, 13);
            this.labelBodyName.TabIndex = 3;
            this.labelBodyName.Text = "Body";
            this.labelBodyName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelBodyName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelBodyName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxPosition.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxPosition.BorderColorScaling = 0.5F;
            this.textBoxPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPosition.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxPosition.Location = new System.Drawing.Point(52, 99);
            this.textBoxPosition.Multiline = false;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPosition.SelectionLength = 0;
            this.textBoxPosition.SelectionStart = 0;
            this.textBoxPosition.Size = new System.Drawing.Size(152, 20);
            this.textBoxPosition.TabIndex = 8;
            this.textBoxPosition.TabStop = false;
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPosition.WordWrap = true;
            this.textBoxPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(3, 99);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(25, 13);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Pos";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxVisits
            // 
            this.textBoxVisits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxVisits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxVisits.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxVisits.BorderColorScaling = 0.5F;
            this.textBoxVisits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVisits.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxVisits.Location = new System.Drawing.Point(52, 51);
            this.textBoxVisits.Multiline = false;
            this.textBoxVisits.Name = "textBoxVisits";
            this.textBoxVisits.ReadOnly = true;
            this.textBoxVisits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxVisits.SelectionLength = 0;
            this.textBoxVisits.SelectionStart = 0;
            this.textBoxVisits.Size = new System.Drawing.Size(66, 20);
            this.textBoxVisits.TabIndex = 10;
            this.textBoxVisits.TabStop = false;
            this.textBoxVisits.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxVisits.WordWrap = true;
            this.textBoxVisits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxVisits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxVisits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelVisits
            // 
            this.labelVisits.AutoSize = true;
            this.labelVisits.Location = new System.Drawing.Point(3, 52);
            this.labelVisits.Name = "labelVisits";
            this.labelVisits.Size = new System.Drawing.Size(31, 13);
            this.labelVisits.TabIndex = 9;
            this.labelVisits.Text = "Visits";
            this.labelVisits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelVisits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelVisits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelVisits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelAllegiance
            // 
            this.labelAllegiance.AutoSize = true;
            this.labelAllegiance.Location = new System.Drawing.Point(124, 147);
            this.labelAllegiance.Name = "labelAllegiance";
            this.labelAllegiance.Size = new System.Drawing.Size(56, 13);
            this.labelAllegiance.TabIndex = 13;
            this.labelAllegiance.Text = "Allegiance";
            this.labelAllegiance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAllegiance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelAllegiance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelAllegiance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelEconomy
            // 
            this.labelEconomy.AutoSize = true;
            this.labelEconomy.Location = new System.Drawing.Point(124, 165);
            this.labelEconomy.Name = "labelEconomy";
            this.labelEconomy.Size = new System.Drawing.Size(51, 13);
            this.labelEconomy.TabIndex = 34;
            this.labelEconomy.Text = "Economy";
            this.labelEconomy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelEconomy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelEconomy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelEconomy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxAllegiance
            // 
            this.textBoxAllegiance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxAllegiance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxAllegiance.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxAllegiance.BorderColorScaling = 0.5F;
            this.textBoxAllegiance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAllegiance.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxAllegiance.Location = new System.Drawing.Point(190, 147);
            this.textBoxAllegiance.Multiline = false;
            this.textBoxAllegiance.Name = "textBoxAllegiance";
            this.textBoxAllegiance.ReadOnly = true;
            this.textBoxAllegiance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAllegiance.SelectionLength = 0;
            this.textBoxAllegiance.SelectionStart = 0;
            this.textBoxAllegiance.Size = new System.Drawing.Size(66, 20);
            this.textBoxAllegiance.TabIndex = 14;
            this.textBoxAllegiance.TabStop = false;
            this.textBoxAllegiance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAllegiance.WordWrap = true;
            this.textBoxAllegiance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxAllegiance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxAllegiance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxGovernment
            // 
            this.textBoxGovernment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxGovernment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxGovernment.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxGovernment.BorderColorScaling = 0.5F;
            this.textBoxGovernment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGovernment.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxGovernment.Location = new System.Drawing.Point(52, 165);
            this.textBoxGovernment.Multiline = false;
            this.textBoxGovernment.Name = "textBoxGovernment";
            this.textBoxGovernment.ReadOnly = true;
            this.textBoxGovernment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGovernment.SelectionLength = 0;
            this.textBoxGovernment.SelectionStart = 0;
            this.textBoxGovernment.Size = new System.Drawing.Size(66, 20);
            this.textBoxGovernment.TabIndex = 35;
            this.textBoxGovernment.TabStop = false;
            this.textBoxGovernment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxGovernment.WordWrap = true;
            this.textBoxGovernment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxGovernment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxGovernment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelGov
            // 
            this.labelGov.AutoSize = true;
            this.labelGov.Location = new System.Drawing.Point(3, 165);
            this.labelGov.Name = "labelGov";
            this.labelGov.Size = new System.Drawing.Size(27, 13);
            this.labelGov.TabIndex = 36;
            this.labelGov.Text = "Gov";
            this.labelGov.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelGov.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelGov.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelGov.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(3, 147);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 38;
            this.labelState.Text = "State";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelState.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxEconomy
            // 
            this.textBoxEconomy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxEconomy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxEconomy.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxEconomy.BorderColorScaling = 0.5F;
            this.textBoxEconomy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEconomy.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxEconomy.Location = new System.Drawing.Point(190, 165);
            this.textBoxEconomy.Multiline = false;
            this.textBoxEconomy.Name = "textBoxEconomy";
            this.textBoxEconomy.ReadOnly = true;
            this.textBoxEconomy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEconomy.SelectionLength = 0;
            this.textBoxEconomy.SelectionStart = 0;
            this.textBoxEconomy.Size = new System.Drawing.Size(66, 20);
            this.textBoxEconomy.TabIndex = 33;
            this.textBoxEconomy.TabStop = false;
            this.textBoxEconomy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEconomy.WordWrap = true;
            this.textBoxEconomy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxEconomy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxEconomy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxState
            // 
            this.textBoxState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxState.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxState.BorderColorScaling = 0.5F;
            this.textBoxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxState.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxState.Location = new System.Drawing.Point(52, 147);
            this.textBoxState.Multiline = false;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxState.SelectionLength = 0;
            this.textBoxState.SelectionStart = 0;
            this.textBoxState.Size = new System.Drawing.Size(66, 20);
            this.textBoxState.TabIndex = 37;
            this.textBoxState.TabStop = false;
            this.textBoxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxState.WordWrap = true;
            this.textBoxState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxState.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // buttonEDDB
            // 
            this.buttonEDDB.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEDDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEDDB.DrawnImage = null;
            this.buttonEDDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEDDB.ImageSelected = ExtendedControls.DrawnPanel.ImageType.EDDB;
            this.buttonEDDB.ImageText = null;
            this.buttonEDDB.Location = new System.Drawing.Point(97, 25);
            this.buttonEDDB.MarginSize = 0;
            this.buttonEDDB.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDDB.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDDB.MouseSelectedColorEnable = true;
            this.buttonEDDB.Name = "buttonEDDB";
            this.buttonEDDB.Size = new System.Drawing.Size(20, 20);
            this.buttonEDDB.TabIndex = 5;
            this.toolTipEddb.SetToolTip(this.buttonEDDB, "Click to show system in EDDB");
            this.buttonEDDB.Click += new System.EventHandler(this.buttonEDDB_Click);
            this.buttonEDDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.buttonEDDB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.buttonEDDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // buttonRoss
            // 
            this.buttonRoss.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonRoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoss.DrawnImage = null;
            this.buttonRoss.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRoss.ImageSelected = ExtendedControls.DrawnPanel.ImageType.Ross;
            this.buttonRoss.ImageText = null;
            this.buttonRoss.Location = new System.Drawing.Point(120, 25);
            this.buttonRoss.MarginSize = 0;
            this.buttonRoss.MouseOverColor = System.Drawing.Color.White;
            this.buttonRoss.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonRoss.MouseSelectedColorEnable = true;
            this.buttonRoss.Name = "buttonRoss";
            this.buttonRoss.Size = new System.Drawing.Size(20, 20);
            this.buttonRoss.TabIndex = 6;
            this.toolTipEddb.SetToolTip(this.buttonRoss, "Click to edit system in Ross");
            this.buttonRoss.Click += new System.EventHandler(this.buttonRoss_Click);
            this.buttonRoss.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.buttonRoss.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.buttonRoss.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxHomeDist
            // 
            this.textBoxHomeDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxHomeDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxHomeDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxHomeDist.BorderColorScaling = 0.5F;
            this.textBoxHomeDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHomeDist.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxHomeDist.Location = new System.Drawing.Point(52, 123);
            this.textBoxHomeDist.Multiline = false;
            this.textBoxHomeDist.Name = "textBoxHomeDist";
            this.textBoxHomeDist.ReadOnly = true;
            this.textBoxHomeDist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxHomeDist.SelectionLength = 0;
            this.textBoxHomeDist.SelectionStart = 0;
            this.textBoxHomeDist.Size = new System.Drawing.Size(67, 20);
            this.textBoxHomeDist.TabIndex = 42;
            this.textBoxHomeDist.TabStop = false;
            this.textBoxHomeDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipEddb.SetToolTip(this.textBoxHomeDist, "Distance to home system");
            this.textBoxHomeDist.WordWrap = true;
            this.textBoxHomeDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxHomeDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxHomeDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelHomeDist
            // 
            this.labelHomeDist.AutoSize = true;
            this.labelHomeDist.Location = new System.Drawing.Point(3, 122);
            this.labelHomeDist.Name = "labelHomeDist";
            this.labelHomeDist.Size = new System.Drawing.Size(35, 13);
            this.labelHomeDist.TabIndex = 43;
            this.labelHomeDist.Text = "Home";
            this.labelHomeDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelHomeDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelHomeDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelHomeDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // buttonEDSM
            // 
            this.buttonEDSM.DrawnImage = null;
            this.buttonEDSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDSM.ImageSelected = ExtendedControls.DrawnPanel.ImageType.InverseText;
            this.buttonEDSM.ImageText = "EDSM";
            this.buttonEDSM.Location = new System.Drawing.Point(53, 25);
            this.buttonEDSM.MarginSize = 0;
            this.buttonEDSM.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDSM.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDSM.MouseSelectedColorEnable = true;
            this.buttonEDSM.Name = "buttonEDSM";
            this.buttonEDSM.Size = new System.Drawing.Size(44, 20);
            this.buttonEDSM.TabIndex = 4;
            this.toolTipEddb.SetToolTip(this.buttonEDSM, "Click to show system on EDSM");
            this.buttonEDSM.Click += new System.EventHandler(this.buttonEDSM_Click);
            this.buttonEDSM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.buttonEDSM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.buttonEDSM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxSolDist
            // 
            this.textBoxSolDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSolDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSolDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSolDist.BorderColorScaling = 0.5F;
            this.textBoxSolDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSolDist.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxSolDist.Location = new System.Drawing.Point(190, 123);
            this.textBoxSolDist.Multiline = false;
            this.textBoxSolDist.Name = "textBoxSolDist";
            this.textBoxSolDist.ReadOnly = true;
            this.textBoxSolDist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSolDist.SelectionLength = 0;
            this.textBoxSolDist.SelectionStart = 0;
            this.textBoxSolDist.Size = new System.Drawing.Size(67, 20);
            this.textBoxSolDist.TabIndex = 44;
            this.textBoxSolDist.TabStop = false;
            this.textBoxSolDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipEddb.SetToolTip(this.textBoxSolDist, "Distance to Sol");
            this.textBoxSolDist.WordWrap = true;
            this.textBoxSolDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxSolDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxSolDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelSolDist
            // 
            this.labelSolDist.AutoSize = true;
            this.labelSolDist.Location = new System.Drawing.Point(124, 123);
            this.labelSolDist.Name = "labelSolDist";
            this.labelSolDist.Size = new System.Drawing.Size(22, 13);
            this.labelSolDist.TabIndex = 45;
            this.labelSolDist.Text = "Sol";
            this.labelSolDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelSolDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelSolDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelSolDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // toolTipEddb
            // 
            this.toolTipEddb.ShowAlways = true;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 191);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 28;
            this.labelNote.Text = "Note";
            this.toolTipEddb.SetToolTip(this.labelNote, "Enter a note against the currently selected entry");
            this.labelNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.BorderColor = System.Drawing.Color.Transparent;
            this.richTextBoxNote.BorderColorScaling = 0.5F;
            this.richTextBoxNote.HideScrollBar = true;
            this.richTextBoxNote.Location = new System.Drawing.Point(50, 191);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.ReadOnly = false;
            this.richTextBoxNote.ScrollBarArrowBorderColor = System.Drawing.Color.LightBlue;
            this.richTextBoxNote.ScrollBarArrowButtonColor = System.Drawing.Color.LightGray;
            this.richTextBoxNote.ScrollBarBackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxNote.ScrollBarBorderColor = System.Drawing.Color.White;
            this.richTextBoxNote.ScrollBarFlatStyle = System.Windows.Forms.FlatStyle.System;
            this.richTextBoxNote.ScrollBarForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxNote.ScrollBarMouseOverButtonColor = System.Drawing.Color.Green;
            this.richTextBoxNote.ScrollBarMousePressedButtonColor = System.Drawing.Color.Red;
            this.richTextBoxNote.ScrollBarSliderColor = System.Drawing.Color.DarkGray;
            this.richTextBoxNote.ScrollBarThumbBorderColor = System.Drawing.Color.Yellow;
            this.richTextBoxNote.ScrollBarThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.richTextBoxNote.ScrollBarWidth = 20;
            this.richTextBoxNote.ShowLineCount = false;
            this.richTextBoxNote.Size = new System.Drawing.Size(277, 50);
            this.richTextBoxNote.TabIndex = 0;
            this.richTextBoxNote.TextBoxBackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxNote.TextBoxForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxNote.TextBoxChanged += new ExtendedControls.RichTextBoxScroll.OnTextBoxChanged(this.richTextBoxNote_TextBoxChanged);
            this.richTextBoxNote.Leave += new System.EventHandler(this.richTextBoxNote_Leave);
            this.richTextBoxNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.richTextBoxNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.richTextBoxNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(2, 254);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(38, 13);
            this.labelTarget.TabIndex = 16;
            this.labelTarget.Text = "Target";
            this.labelTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelTarget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelTarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // buttonEDSMTarget
            // 
            this.buttonEDSMTarget.DrawnImage = null;
            this.buttonEDSMTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDSMTarget.ImageSelected = ExtendedControls.DrawnPanel.ImageType.InverseText;
            this.buttonEDSMTarget.ImageText = "EDSM";
            this.buttonEDSMTarget.Location = new System.Drawing.Point(278, 251);
            this.buttonEDSMTarget.MarginSize = 0;
            this.buttonEDSMTarget.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDSMTarget.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDSMTarget.MouseSelectedColorEnable = true;
            this.buttonEDSMTarget.Name = "buttonEDSMTarget";
            this.buttonEDSMTarget.Size = new System.Drawing.Size(44, 20);
            this.buttonEDSMTarget.TabIndex = 23;
            this.buttonEDSMTarget.Click += new System.EventHandler(this.buttonEDSMTarget_Click);
            this.buttonEDSMTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.buttonEDSMTarget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.buttonEDSMTarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTarget.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTarget.BorderColorScaling = 0.5F;
            this.textBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTarget.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTarget.DropDownBackgroundColor = System.Drawing.Color.Gray;
            this.textBoxTarget.DropDownBorderColor = System.Drawing.Color.Green;
            this.textBoxTarget.DropDownHeight = 200;
            this.textBoxTarget.DropDownItemHeight = 20;
            this.textBoxTarget.DropDownMouseOverBackgroundColor = System.Drawing.Color.Red;
            this.textBoxTarget.DropDownScrollBarButtonColor = System.Drawing.Color.LightGray;
            this.textBoxTarget.DropDownScrollBarColor = System.Drawing.Color.LightGray;
            this.textBoxTarget.DropDownWidth = 0;
            this.textBoxTarget.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxTarget.Location = new System.Drawing.Point(53, 251);
            this.textBoxTarget.Multiline = false;
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = false;
            this.textBoxTarget.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTarget.SelectionLength = 0;
            this.textBoxTarget.SelectionStart = 0;
            this.textBoxTarget.Size = new System.Drawing.Size(151, 20);
            this.textBoxTarget.TabIndex = 15;
            this.textBoxTarget.TabStop = false;
            this.textBoxTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.textBoxTarget, "Sets the target");
            this.textBoxTarget.WordWrap = true;
            this.textBoxTarget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTarget_KeyUp);
            this.textBoxTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxTarget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxTarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxTargetDist
            // 
            this.textBoxTargetDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTargetDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTargetDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTargetDist.BorderColorScaling = 0.5F;
            this.textBoxTargetDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTargetDist.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTargetDist.Location = new System.Drawing.Point(210, 251);
            this.textBoxTargetDist.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBoxTargetDist.Multiline = false;
            this.textBoxTargetDist.Name = "textBoxTargetDist";
            this.textBoxTargetDist.ReadOnly = true;
            this.textBoxTargetDist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTargetDist.SelectionLength = 0;
            this.textBoxTargetDist.SelectionStart = 0;
            this.textBoxTargetDist.Size = new System.Drawing.Size(62, 20);
            this.textBoxTargetDist.TabIndex = 15;
            this.textBoxTargetDist.TabStop = false;
            this.textBoxTargetDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.textBoxTargetDist, "Distance to target");
            this.textBoxTargetDist.WordWrap = true;
            this.textBoxTargetDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxTargetDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxTargetDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSystem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSystem.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSystem.BorderColorScaling = 0.5F;
            this.textBoxSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSystem.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxSystem.Location = new System.Drawing.Point(52, 3);
            this.textBoxSystem.Multiline = false;
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.ReadOnly = true;
            this.textBoxSystem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSystem.SelectionLength = 0;
            this.textBoxSystem.SelectionStart = 0;
            this.textBoxSystem.Size = new System.Drawing.Size(152, 20);
            this.textBoxSystem.TabIndex = 1;
            this.textBoxSystem.TabStop = false;
            this.textBoxSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSystem.WordWrap = true;
            this.textBoxSystem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxSystem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxSystem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelSysName
            // 
            this.labelSysName.AutoSize = true;
            this.labelSysName.Location = new System.Drawing.Point(3, 3);
            this.labelSysName.Name = "labelSysName";
            this.labelSysName.Size = new System.Drawing.Size(41, 13);
            this.labelSysName.TabIndex = 4;
            this.labelSysName.Text = "System";
            this.labelSysName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelSysName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelSysName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(3, 27);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(33, 13);
            this.labelOpen.TabIndex = 3;
            this.labelOpen.Text = "Open";
            this.labelOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelOpen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelGamemode
            // 
            this.labelGamemode.AutoSize = true;
            this.labelGamemode.Location = new System.Drawing.Point(2, 283);
            this.labelGamemode.Name = "labelGamemode";
            this.labelGamemode.Size = new System.Drawing.Size(34, 13);
            this.labelGamemode.TabIndex = 16;
            this.labelGamemode.Text = "Mode";
            this.labelGamemode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelGamemode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelGamemode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelTravel
            // 
            this.labelTravel.AutoSize = true;
            this.labelTravel.Location = new System.Drawing.Point(3, 309);
            this.labelTravel.Name = "labelTravel";
            this.labelTravel.Size = new System.Drawing.Size(37, 13);
            this.labelTravel.TabIndex = 16;
            this.labelTravel.Text = "Travel";
            this.labelTravel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelTravel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelTravel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxGameMode
            // 
            this.textBoxGameMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxGameMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxGameMode.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxGameMode.BorderColorScaling = 0.5F;
            this.textBoxGameMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGameMode.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxGameMode.Location = new System.Drawing.Point(50, 283);
            this.textBoxGameMode.Multiline = false;
            this.textBoxGameMode.Name = "textBoxGameMode";
            this.textBoxGameMode.ReadOnly = true;
            this.textBoxGameMode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGameMode.SelectionLength = 0;
            this.textBoxGameMode.SelectionStart = 0;
            this.textBoxGameMode.Size = new System.Drawing.Size(152, 20);
            this.textBoxGameMode.TabIndex = 8;
            this.textBoxGameMode.TabStop = false;
            this.textBoxGameMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxGameMode.WordWrap = true;
            this.textBoxGameMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxGameMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxGameMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxTravelDist
            // 
            this.textBoxTravelDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTravelDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTravelDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTravelDist.BorderColorScaling = 0.5F;
            this.textBoxTravelDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTravelDist.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTravelDist.Location = new System.Drawing.Point(50, 309);
            this.textBoxTravelDist.Multiline = false;
            this.textBoxTravelDist.Name = "textBoxTravelDist";
            this.textBoxTravelDist.ReadOnly = true;
            this.textBoxTravelDist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTravelDist.SelectionLength = 0;
            this.textBoxTravelDist.SelectionStart = 0;
            this.textBoxTravelDist.Size = new System.Drawing.Size(68, 20);
            this.textBoxTravelDist.TabIndex = 8;
            this.textBoxTravelDist.TabStop = false;
            this.textBoxTravelDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTravelDist.WordWrap = true;
            this.textBoxTravelDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxTravelDist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxTravelDist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxTravelTime
            // 
            this.textBoxTravelTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTravelTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTravelTime.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTravelTime.BorderColorScaling = 0.5F;
            this.textBoxTravelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTravelTime.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTravelTime.Location = new System.Drawing.Point(127, 309);
            this.textBoxTravelTime.Multiline = false;
            this.textBoxTravelTime.Name = "textBoxTravelTime";
            this.textBoxTravelTime.ReadOnly = true;
            this.textBoxTravelTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTravelTime.SelectionLength = 0;
            this.textBoxTravelTime.SelectionStart = 0;
            this.textBoxTravelTime.Size = new System.Drawing.Size(85, 20);
            this.textBoxTravelTime.TabIndex = 8;
            this.textBoxTravelTime.TabStop = false;
            this.textBoxTravelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTravelTime.WordWrap = true;
            this.textBoxTravelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxTravelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxTravelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxTravelJumps
            // 
            this.textBoxTravelJumps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTravelJumps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTravelJumps.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTravelJumps.BorderColorScaling = 0.5F;
            this.textBoxTravelJumps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTravelJumps.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTravelJumps.Location = new System.Drawing.Point(218, 309);
            this.textBoxTravelJumps.Multiline = false;
            this.textBoxTravelJumps.Name = "textBoxTravelJumps";
            this.textBoxTravelJumps.ReadOnly = true;
            this.textBoxTravelJumps.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTravelJumps.SelectionLength = 0;
            this.textBoxTravelJumps.SelectionStart = 0;
            this.textBoxTravelJumps.Size = new System.Drawing.Size(85, 20);
            this.textBoxTravelJumps.TabIndex = 8;
            this.textBoxTravelJumps.TabStop = false;
            this.textBoxTravelJumps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTravelJumps.WordWrap = true;
            this.textBoxTravelJumps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxTravelJumps.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxTravelJumps.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(2, 342);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(35, 13);
            this.labelCargo.TabIndex = 16;
            this.labelCargo.Text = "Cargo";
            this.labelCargo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelCargo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelCargo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxCargo.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxCargo.BorderColorScaling = 0.5F;
            this.textBoxCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCargo.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxCargo.Location = new System.Drawing.Point(50, 339);
            this.textBoxCargo.Multiline = false;
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.ReadOnly = true;
            this.textBoxCargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCargo.SelectionLength = 0;
            this.textBoxCargo.SelectionStart = 0;
            this.textBoxCargo.Size = new System.Drawing.Size(68, 20);
            this.textBoxCargo.TabIndex = 8;
            this.textBoxCargo.TabStop = false;
            this.textBoxCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCargo.WordWrap = true;
            this.textBoxCargo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxCargo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxCargo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // textBoxMaterials
            // 
            this.textBoxMaterials.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxMaterials.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxMaterials.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxMaterials.BorderColorScaling = 0.5F;
            this.textBoxMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaterials.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxMaterials.Location = new System.Drawing.Point(188, 339);
            this.textBoxMaterials.Multiline = false;
            this.textBoxMaterials.Name = "textBoxMaterials";
            this.textBoxMaterials.ReadOnly = true;
            this.textBoxMaterials.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMaterials.SelectionLength = 0;
            this.textBoxMaterials.SelectionStart = 0;
            this.textBoxMaterials.Size = new System.Drawing.Size(68, 20);
            this.textBoxMaterials.TabIndex = 8;
            this.textBoxMaterials.TabStop = false;
            this.textBoxMaterials.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMaterials.WordWrap = true;
            this.textBoxMaterials.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.textBoxMaterials.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.textBoxMaterials.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Location = new System.Drawing.Point(124, 342);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(49, 13);
            this.labelMaterials.TabIndex = 16;
            this.labelMaterials.Text = "Materials";
            this.labelMaterials.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMouseDown);
            this.labelMaterials.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMouseMove);
            this.labelMaterials.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlMouseUp);
            // 
            // UserControlSysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.labelSysName);
            this.Controls.Add(this.textBoxSystem);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.buttonEDSM);
            this.Controls.Add(this.buttonEDDB);
            this.Controls.Add(this.buttonRoss);
            this.Controls.Add(this.labelVisits);
            this.Controls.Add(this.textBoxVisits);
            this.Controls.Add(this.labelBodyName);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxTravelJumps);
            this.Controls.Add(this.textBoxTravelTime);
            this.Controls.Add(this.textBoxMaterials);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.textBoxTravelDist);
            this.Controls.Add(this.textBoxGameMode);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelHomeDist);
            this.Controls.Add(this.textBoxHomeDist);
            this.Controls.Add(this.labelSolDist);
            this.Controls.Add(this.textBoxSolDist);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelAllegiance);
            this.Controls.Add(this.textBoxAllegiance);
            this.Controls.Add(this.labelGov);
            this.Controls.Add(this.textBoxGovernment);
            this.Controls.Add(this.labelEconomy);
            this.Controls.Add(this.textBoxEconomy);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTravel);
            this.Controls.Add(this.labelGamemode);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxTargetDist);
            this.Controls.Add(this.buttonEDSMTarget);
            this.Name = "UserControlSysInfo";
            this.Size = new System.Drawing.Size(393, 456);
            this.Resize += new System.EventHandler(this.UserControlSysInfo_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private ExtendedControls.TextBoxBorder textBoxBody;
        private System.Windows.Forms.Label labelBodyName;
        private ExtendedControls.TextBoxBorder textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private ExtendedControls.TextBoxBorder textBoxVisits;
        private System.Windows.Forms.Label labelVisits;
        private System.Windows.Forms.Label labelAllegiance;
        private System.Windows.Forms.Label labelEconomy;
        private ExtendedControls.TextBoxBorder textBoxAllegiance;
        private ExtendedControls.TextBoxBorder textBoxGovernment;
        private System.Windows.Forms.Label labelGov;
        private System.Windows.Forms.Label labelState;
        private ExtendedControls.TextBoxBorder textBoxEconomy;
        private ExtendedControls.TextBoxBorder textBoxState;
        private ExtendedControls.DrawnPanel buttonEDDB;
        private System.Windows.Forms.ToolTip toolTipEddb;
        private ExtendedControls.DrawnPanel buttonRoss;
        private ExtendedControls.TextBoxBorder textBoxHomeDist;
        private System.Windows.Forms.Label labelHomeDist;
        private ExtendedControls.DrawnPanel buttonEDSM;
        private ExtendedControls.TextBoxBorder textBoxSolDist;
        private System.Windows.Forms.Label labelSolDist;
        private ExtendedControls.RichTextBoxScroll richTextBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelTarget;
        private ExtendedControls.DrawnPanel buttonEDSMTarget;
        private ExtendedControls.AutoCompleteTextBox textBoxTarget;
        private System.Windows.Forms.ToolTip toolTip1;
        private ExtendedControls.TextBoxBorder textBoxTargetDist;
        private ExtendedControls.TextBoxBorder textBoxSystem;
        private System.Windows.Forms.Label labelSysName;
        private System.Windows.Forms.ToolStripMenuItem toolStripNotes;
        private System.Windows.Forms.ToolStripMenuItem toolStripSystem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBody;
        private System.Windows.Forms.ToolStripMenuItem toolStripTarget;
        private System.Windows.Forms.ToolStripMenuItem toolStripEDSMDownLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripEDSM;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripVisits;
        private System.Windows.Forms.ToolStripMenuItem toolStripPosition;
        private System.Windows.Forms.ToolStripMenuItem toolStripSystemState;
        private System.Windows.Forms.ToolStripMenuItem toolStripDistanceFrom;
        private System.Windows.Forms.Label labelGamemode;
        private System.Windows.Forms.Label labelTravel;
        private ExtendedControls.TextBoxBorder textBoxGameMode;
        private ExtendedControls.TextBoxBorder textBoxTravelDist;
        private ExtendedControls.TextBoxBorder textBoxTravelTime;
        private ExtendedControls.TextBoxBorder textBoxTravelJumps;
        private System.Windows.Forms.Label labelCargo;
        private ExtendedControls.TextBoxBorder textBoxCargo;
        private ExtendedControls.TextBoxBorder textBoxMaterials;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.ToolStripMenuItem toolStripGameMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripTravel;
        private System.Windows.Forms.ToolStripMenuItem toolStripCargo;
    }
}
