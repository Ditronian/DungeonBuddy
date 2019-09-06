using DungeonBuddy.Entities;
using System.Collections.Generic;

namespace DungeonBuddy.GUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.partyView = new System.Windows.Forms.TabPage();
            this.partyIsNpcCheckbox = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.partySizeTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.partyACTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.partyHPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partyPerceptionTextBox = new System.Windows.Forms.TextBox();
            this.partyRaceTextBox = new System.Windows.Forms.TextBox();
            this.partyNameTextBox = new System.Windows.Forms.TextBox();
            this.removePartyButton = new System.Windows.Forms.Button();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.partyListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.combatView = new System.Windows.Forms.TabPage();
            this.combatIsNPCCheckbox = new System.Windows.Forms.CheckBox();
            this.combatDiceModifierTextBox = new System.Windows.Forms.TextBox();
            this.combatDiceSizeTextBox = new System.Windows.Forms.TextBox();
            this.combatNumberDiceTextBox = new System.Windows.Forms.TextBox();
            this.combatRollDiceButton = new System.Windows.Forms.Button();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.loadCombatButton = new System.Windows.Forms.Button();
            this.saveCombatButton = new System.Windows.Forms.Button();
            this.monsterDamageTextBox = new System.Windows.Forms.TextBox();
            this.monsterDamageButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.monsterACTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monsterHPTextBox = new System.Windows.Forms.TextBox();
            this.monsterInitiativeTextBox = new System.Windows.Forms.TextBox();
            this.monsterNameTextBox = new System.Windows.Forms.TextBox();
            this.removeCombatButton = new System.Windows.Forms.Button();
            this.addCombatButton = new System.Windows.Forms.Button();
            this.combatListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.npcView = new System.Windows.Forms.TabPage();
            this.npcTalentLabel = new System.Windows.Forms.Label();
            this.npcFlawLabel = new System.Windows.Forms.Label();
            this.npcInteractionLabel = new System.Windows.Forms.Label();
            this.npcMannerismLabel = new System.Windows.Forms.Label();
            this.npcNameLabel = new System.Windows.Forms.Label();
            this.npcSexLabel = new System.Windows.Forms.Label();
            this.npcRaceLabel = new System.Windows.Forms.Label();
            this.npcLocationLabel = new System.Windows.Forms.Label();
            this.npcAppearanceLabel = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.npcLocationTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.npcRaceTextBox = new System.Windows.Forms.TextBox();
            this.npcSexTextBox = new System.Windows.Forms.TextBox();
            this.npcNameTextBox = new System.Windows.Forms.TextBox();
            this.removeNPCButton = new System.Windows.Forms.Button();
            this.addNPCButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.npcBiographyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.npcListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.generatorView = new System.Windows.Forms.TabPage();
            this.generatorTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.talentLabel = new System.Windows.Forms.TextBox();
            this.flawLabel = new System.Windows.Forms.TextBox();
            this.interactionLabel = new System.Windows.Forms.TextBox();
            this.mannerismLabel = new System.Windows.Forms.TextBox();
            this.appearanceLabel = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.TextBox();
            this.createNPCButton = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.allTraitsButton = new System.Windows.Forms.Button();
            this.talentButton = new System.Windows.Forms.Button();
            this.flawButton = new System.Windows.Forms.Button();
            this.interactionButton = new System.Windows.Forms.Button();
            this.mannerismButton = new System.Windows.Forms.Button();
            this.appearanceButton = new System.Windows.Forms.Button();
            this.rollFullNameButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.generatorLocationTextBox = new System.Windows.Forms.TextBox();
            this.saveNPCButton = new System.Windows.Forms.Button();
            this.rollLastNameButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rollFirstNameButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.npcBioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.settlementRaceTextBox = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.rollSettlementButton = new System.Windows.Forms.Button();
            this.settlementCurrentCalamityTextBox = new System.Windows.Forms.TextBox();
            this.settlementKnownForTextBox = new System.Windows.Forms.TextBox();
            this.settlementNotableTraitTextBox = new System.Windows.Forms.TextBox();
            this.settlementRulerStatusTextBox = new System.Windows.Forms.TextBox();
            this.settlementRaceRelationsTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.settlementNameTextBox = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.rollSettlementTraitsButton = new System.Windows.Forms.Button();
            this.rollSettlementNameButton = new System.Windows.Forms.Button();
            this.rollSettlementRulerStatusButton = new System.Windows.Forms.Button();
            this.rollSettlementRelationsButton = new System.Windows.Forms.Button();
            this.rollSettlementCalamityButton = new System.Windows.Forms.Button();
            this.rollSettlementKnownForButton = new System.Windows.Forms.Button();
            this.settlementCountryTextBox = new System.Windows.Forms.TextBox();
            this.saveSettlementButton = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.settlementDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.rollSettlementNotableTraitButton = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.settlementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.geographyNameLabel = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.geographyButton = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.geographyComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label56 = new System.Windows.Forms.Label();
            this.treasureTextBox = new System.Windows.Forms.TextBox();
            this.treasureLabel = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.rollTreasureButton = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.magicItemShopListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.generateShopButton = new System.Windows.Forms.Button();
            this.label62 = new System.Windows.Forms.Label();
            this.magicItemShopQualityComboBox = new System.Windows.Forms.ComboBox();
            this.miscView = new System.Windows.Forms.TabPage();
            this.miscTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.survivalNotesTextBox = new System.Windows.Forms.RichTextBox();
            this.biomeLabel = new System.Windows.Forms.Label();
            this.plainsRadioButton = new System.Windows.Forms.RadioButton();
            this.arcticRadioButton = new System.Windows.Forms.RadioButton();
            this.foodForagedLabel = new System.Windows.Forms.Label();
            this.movementLabel = new System.Windows.Forms.Label();
            this.decerementMovementButton = new System.Windows.Forms.Button();
            this.incerementMovementButton = new System.Windows.Forms.Button();
            this.decerementFoodButton = new System.Windows.Forms.Button();
            this.incerementFoodButton = new System.Windows.Forms.Button();
            this.daysWithoutFoodLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.foodRemainingLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rationLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.endDayButton = new System.Windows.Forms.Button();
            this.weatherEffectLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.diceRollButton = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.labe53 = new System.Windows.Forms.Label();
            this.diceResultLabel = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.modifierTextBox = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.diceSizeTextBox = new System.Windows.Forms.TextBox();
            this.numberDiceTextBox = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.dmView = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.HeightControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.notificationBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.setFoodTextBox = new System.Windows.Forms.TextBox();
            this.setFoodButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.partyView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyListView)).BeginInit();
            this.combatView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatListView)).BeginInit();
            this.npcView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcListView)).BeginInit();
            this.generatorView.SuspendLayout();
            this.generatorTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magicItemShopListView)).BeginInit();
            this.miscView.SuspendLayout();
            this.miscTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.dmView.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl.Controls.Add(this.partyView);
            this.TabControl.Controls.Add(this.combatView);
            this.TabControl.Controls.Add(this.npcView);
            this.TabControl.Controls.Add(this.generatorView);
            this.TabControl.Controls.Add(this.miscView);
            this.TabControl.Controls.Add(this.dmView);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(150, 60);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(920, 739);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 1;
            // 
            // partyView
            // 
            this.partyView.Controls.Add(this.partyIsNpcCheckbox);
            this.partyView.Controls.Add(this.label32);
            this.partyView.Controls.Add(this.partySizeTextBox);
            this.partyView.Controls.Add(this.label28);
            this.partyView.Controls.Add(this.partyACTextBox);
            this.partyView.Controls.Add(this.label7);
            this.partyView.Controls.Add(this.partyHPTextBox);
            this.partyView.Controls.Add(this.label4);
            this.partyView.Controls.Add(this.label5);
            this.partyView.Controls.Add(this.label6);
            this.partyView.Controls.Add(this.partyPerceptionTextBox);
            this.partyView.Controls.Add(this.partyRaceTextBox);
            this.partyView.Controls.Add(this.partyNameTextBox);
            this.partyView.Controls.Add(this.removePartyButton);
            this.partyView.Controls.Add(this.addPartyButton);
            this.partyView.Controls.Add(this.partyListView);
            this.partyView.Location = new System.Drawing.Point(4, 64);
            this.partyView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyView.Name = "partyView";
            this.partyView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyView.Size = new System.Drawing.Size(912, 671);
            this.partyView.TabIndex = 0;
            this.partyView.Text = "Party";
            this.partyView.UseVisualStyleBackColor = true;
            // 
            // partyIsNpcCheckbox
            // 
            this.partyIsNpcCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyIsNpcCheckbox.AutoSize = true;
            this.partyIsNpcCheckbox.Location = new System.Drawing.Point(133, 631);
            this.partyIsNpcCheckbox.Name = "partyIsNpcCheckbox";
            this.partyIsNpcCheckbox.Size = new System.Drawing.Size(70, 22);
            this.partyIsNpcCheckbox.TabIndex = 31;
            this.partyIsNpcCheckbox.Text = "NPC?";
            this.partyIsNpcCheckbox.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(845, 599);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 29);
            this.label32.TabIndex = 23;
            this.label32.Text = "Size";
            // 
            // partySizeTextBox
            // 
            this.partySizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partySizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partySizeTextBox.Location = new System.Drawing.Point(842, 559);
            this.partySizeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partySizeTextBox.Name = "partySizeTextBox";
            this.partySizeTextBox.Size = new System.Drawing.Size(63, 38);
            this.partySizeTextBox.TabIndex = 22;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(766, 599);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 29);
            this.label28.TabIndex = 21;
            this.label28.Text = "AC";
            // 
            // partyACTextBox
            // 
            this.partyACTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyACTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyACTextBox.Location = new System.Drawing.Point(745, 559);
            this.partyACTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyACTextBox.Name = "partyACTextBox";
            this.partyACTextBox.Size = new System.Drawing.Size(91, 38);
            this.partyACTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "HP";
            // 
            // partyHPTextBox
            // 
            this.partyHPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyHPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyHPTextBox.Location = new System.Drawing.Point(648, 559);
            this.partyHPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyHPTextBox.Name = "partyHPTextBox";
            this.partyHPTextBox.Size = new System.Drawing.Size(91, 38);
            this.partyHPTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Perception";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Race";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // partyPerceptionTextBox
            // 
            this.partyPerceptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyPerceptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyPerceptionTextBox.Location = new System.Drawing.Point(504, 558);
            this.partyPerceptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyPerceptionTextBox.Name = "partyPerceptionTextBox";
            this.partyPerceptionTextBox.Size = new System.Drawing.Size(138, 38);
            this.partyPerceptionTextBox.TabIndex = 14;
            // 
            // partyRaceTextBox
            // 
            this.partyRaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyRaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyRaceTextBox.Location = new System.Drawing.Point(346, 558);
            this.partyRaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyRaceTextBox.Name = "partyRaceTextBox";
            this.partyRaceTextBox.Size = new System.Drawing.Size(152, 38);
            this.partyRaceTextBox.TabIndex = 13;
            // 
            // partyNameTextBox
            // 
            this.partyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyNameTextBox.Location = new System.Drawing.Point(134, 558);
            this.partyNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyNameTextBox.Name = "partyNameTextBox";
            this.partyNameTextBox.Size = new System.Drawing.Size(206, 38);
            this.partyNameTextBox.TabIndex = 12;
            // 
            // removePartyButton
            // 
            this.removePartyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removePartyButton.Location = new System.Drawing.Point(6, 610);
            this.removePartyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removePartyButton.Name = "removePartyButton";
            this.removePartyButton.Size = new System.Drawing.Size(121, 57);
            this.removePartyButton.TabIndex = 11;
            this.removePartyButton.Text = "Remove Selected";
            this.removePartyButton.UseVisualStyleBackColor = true;
            this.removePartyButton.Click += new System.EventHandler(this.removePartyButton_Click);
            // 
            // addPartyButton
            // 
            this.addPartyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPartyButton.Location = new System.Drawing.Point(6, 547);
            this.addPartyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(121, 57);
            this.addPartyButton.TabIndex = 10;
            this.addPartyButton.Text = "Add Party Member";
            this.addPartyButton.UseVisualStyleBackColor = true;
            this.addPartyButton.Click += new System.EventHandler(this.addPartyButton_Click);
            // 
            // partyListView
            // 
            this.partyListView.AllColumns.Add(this.olvColumn6);
            this.partyListView.AllColumns.Add(this.olvColumn10);
            this.partyListView.AllColumns.Add(this.olvColumn11);
            this.partyListView.AllColumns.Add(this.olvColumn9);
            this.partyListView.AllColumns.Add(this.olvColumn12);
            this.partyListView.AllColumns.Add(this.olvColumn15);
            this.partyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partyListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.partyListView.CellEditUseWholeCell = false;
            this.partyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn10,
            this.olvColumn11,
            this.olvColumn9,
            this.olvColumn12,
            this.olvColumn15});
            this.partyListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.partyListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyListView.GridLines = true;
            this.partyListView.Location = new System.Drawing.Point(5, 6);
            this.partyListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyListView.Name = "partyListView";
            this.partyListView.ShowGroups = false;
            this.partyListView.Size = new System.Drawing.Size(900, 533);
            this.partyListView.TabIndex = 2;
            this.partyListView.UseCompatibleStateImageBehavior = false;
            this.partyListView.View = System.Windows.Forms.View.Details;
            this.partyListView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.partyListView_FormatRow);
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Name";
            this.olvColumn6.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn6.Text = "Name";
            this.olvColumn6.Width = 215;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Race";
            this.olvColumn10.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn10.Text = "Race";
            this.olvColumn10.Width = 141;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "PassivePerception";
            this.olvColumn11.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn11.Text = "Passive Perception";
            this.olvColumn11.Width = 213;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "CurrentHP";
            this.olvColumn9.Text = "Current HP";
            this.olvColumn9.Width = 125;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "MaxHP";
            this.olvColumn12.Text = "Max HP";
            this.olvColumn12.Width = 94;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "Size";
            this.olvColumn15.Text = "Size";
            // 
            // combatView
            // 
            this.combatView.Controls.Add(this.combatIsNPCCheckbox);
            this.combatView.Controls.Add(this.combatDiceModifierTextBox);
            this.combatView.Controls.Add(this.combatDiceSizeTextBox);
            this.combatView.Controls.Add(this.combatNumberDiceTextBox);
            this.combatView.Controls.Add(this.combatRollDiceButton);
            this.combatView.Controls.Add(this.label64);
            this.combatView.Controls.Add(this.label65);
            this.combatView.Controls.Add(this.label67);
            this.combatView.Controls.Add(this.label68);
            this.combatView.Controls.Add(this.label69);
            this.combatView.Controls.Add(this.loadCombatButton);
            this.combatView.Controls.Add(this.saveCombatButton);
            this.combatView.Controls.Add(this.monsterDamageTextBox);
            this.combatView.Controls.Add(this.monsterDamageButton);
            this.combatView.Controls.Add(this.label23);
            this.combatView.Controls.Add(this.monsterACTextBox);
            this.combatView.Controls.Add(this.label3);
            this.combatView.Controls.Add(this.label2);
            this.combatView.Controls.Add(this.label1);
            this.combatView.Controls.Add(this.monsterHPTextBox);
            this.combatView.Controls.Add(this.monsterInitiativeTextBox);
            this.combatView.Controls.Add(this.monsterNameTextBox);
            this.combatView.Controls.Add(this.removeCombatButton);
            this.combatView.Controls.Add(this.addCombatButton);
            this.combatView.Controls.Add(this.combatListView);
            this.combatView.Location = new System.Drawing.Point(4, 64);
            this.combatView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatView.Name = "combatView";
            this.combatView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatView.Size = new System.Drawing.Size(912, 671);
            this.combatView.TabIndex = 1;
            this.combatView.Text = "Combat Tracker";
            this.combatView.UseVisualStyleBackColor = true;
            // 
            // combatIsNPCCheckbox
            // 
            this.combatIsNPCCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combatIsNPCCheckbox.AutoSize = true;
            this.combatIsNPCCheckbox.Location = new System.Drawing.Point(260, 591);
            this.combatIsNPCCheckbox.Name = "combatIsNPCCheckbox";
            this.combatIsNPCCheckbox.Size = new System.Drawing.Size(70, 22);
            this.combatIsNPCCheckbox.TabIndex = 30;
            this.combatIsNPCCheckbox.Text = "NPC?";
            this.combatIsNPCCheckbox.UseVisualStyleBackColor = true;
            // 
            // combatDiceModifierTextBox
            // 
            this.combatDiceModifierTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combatDiceModifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatDiceModifierTextBox.Location = new System.Drawing.Point(743, 629);
            this.combatDiceModifierTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatDiceModifierTextBox.Name = "combatDiceModifierTextBox";
            this.combatDiceModifierTextBox.Size = new System.Drawing.Size(59, 38);
            this.combatDiceModifierTextBox.TabIndex = 29;
            // 
            // combatDiceSizeTextBox
            // 
            this.combatDiceSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combatDiceSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatDiceSizeTextBox.Location = new System.Drawing.Point(640, 629);
            this.combatDiceSizeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatDiceSizeTextBox.Name = "combatDiceSizeTextBox";
            this.combatDiceSizeTextBox.Size = new System.Drawing.Size(60, 38);
            this.combatDiceSizeTextBox.TabIndex = 28;
            // 
            // combatNumberDiceTextBox
            // 
            this.combatNumberDiceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combatNumberDiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatNumberDiceTextBox.Location = new System.Drawing.Point(538, 629);
            this.combatNumberDiceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatNumberDiceTextBox.Name = "combatNumberDiceTextBox";
            this.combatNumberDiceTextBox.Size = new System.Drawing.Size(59, 38);
            this.combatNumberDiceTextBox.TabIndex = 27;
            // 
            // combatRollDiceButton
            // 
            this.combatRollDiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combatRollDiceButton.Location = new System.Drawing.Point(808, 629);
            this.combatRollDiceButton.Name = "combatRollDiceButton";
            this.combatRollDiceButton.Size = new System.Drawing.Size(84, 38);
            this.combatRollDiceButton.TabIndex = 26;
            this.combatRollDiceButton.Text = "Roll Dice!";
            this.combatRollDiceButton.UseVisualStyleBackColor = true;
            this.combatRollDiceButton.Click += new System.EventHandler(this.combatRollDiceButton_Click);
            // 
            // label64
            // 
            this.label64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(740, 609);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(69, 18);
            this.label64.TabIndex = 25;
            this.label64.Text = "Modifiers";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(637, 609);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(71, 18);
            this.label65.TabIndex = 24;
            this.label65.Text = "Dice Size";
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(547, 609);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(50, 18);
            this.label67.TabIndex = 23;
            this.label67.Text = "# Dice";
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(706, 632);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(31, 32);
            this.label68.TabIndex = 21;
            this.label68.Text = "+";
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(603, 632);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(31, 32);
            this.label69.TabIndex = 18;
            this.label69.Text = "d";
            // 
            // loadCombatButton
            // 
            this.loadCombatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadCombatButton.Location = new System.Drawing.Point(6, 606);
            this.loadCombatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadCombatButton.Name = "loadCombatButton";
            this.loadCombatButton.Size = new System.Drawing.Size(121, 57);
            this.loadCombatButton.TabIndex = 17;
            this.loadCombatButton.Text = "Load Encounter";
            this.loadCombatButton.UseVisualStyleBackColor = true;
            this.loadCombatButton.Click += new System.EventHandler(this.loadCombatButton_Click);
            // 
            // saveCombatButton
            // 
            this.saveCombatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveCombatButton.Location = new System.Drawing.Point(6, 543);
            this.saveCombatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveCombatButton.Name = "saveCombatButton";
            this.saveCombatButton.Size = new System.Drawing.Size(121, 57);
            this.saveCombatButton.TabIndex = 16;
            this.saveCombatButton.Text = "Save Encounter";
            this.saveCombatButton.UseVisualStyleBackColor = true;
            this.saveCombatButton.Click += new System.EventHandler(this.saveCombatButton_Click);
            // 
            // monsterDamageTextBox
            // 
            this.monsterDamageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterDamageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterDamageTextBox.Location = new System.Drawing.Point(260, 618);
            this.monsterDamageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterDamageTextBox.Name = "monsterDamageTextBox";
            this.monsterDamageTextBox.Size = new System.Drawing.Size(80, 38);
            this.monsterDamageTextBox.TabIndex = 15;
            // 
            // monsterDamageButton
            // 
            this.monsterDamageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterDamageButton.Location = new System.Drawing.Point(346, 612);
            this.monsterDamageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterDamageButton.Name = "monsterDamageButton";
            this.monsterDamageButton.Size = new System.Drawing.Size(90, 51);
            this.monsterDamageButton.TabIndex = 14;
            this.monsterDamageButton.Text = "Damage Selected";
            this.monsterDamageButton.UseVisualStyleBackColor = true;
            this.monsterDamageButton.Click += new System.EventHandler(this.monsterDamageButton_Click);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(836, 588);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 20);
            this.label23.TabIndex = 11;
            this.label23.Text = "AC";
            // 
            // monsterACTextBox
            // 
            this.monsterACTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterACTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterACTextBox.Location = new System.Drawing.Point(812, 548);
            this.monsterACTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterACTextBox.Name = "monsterACTextBox";
            this.monsterACTextBox.Size = new System.Drawing.Size(80, 38);
            this.monsterACTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "HP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Initiative";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // monsterHPTextBox
            // 
            this.monsterHPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterHPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHPTextBox.Location = new System.Drawing.Point(654, 548);
            this.monsterHPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterHPTextBox.Name = "monsterHPTextBox";
            this.monsterHPTextBox.Size = new System.Drawing.Size(152, 38);
            this.monsterHPTextBox.TabIndex = 6;
            // 
            // monsterInitiativeTextBox
            // 
            this.monsterInitiativeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterInitiativeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterInitiativeTextBox.Location = new System.Drawing.Point(496, 548);
            this.monsterInitiativeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterInitiativeTextBox.Name = "monsterInitiativeTextBox";
            this.monsterInitiativeTextBox.Size = new System.Drawing.Size(152, 38);
            this.monsterInitiativeTextBox.TabIndex = 5;
            // 
            // monsterNameTextBox
            // 
            this.monsterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monsterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterNameTextBox.Location = new System.Drawing.Point(260, 548);
            this.monsterNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterNameTextBox.Name = "monsterNameTextBox";
            this.monsterNameTextBox.Size = new System.Drawing.Size(231, 38);
            this.monsterNameTextBox.TabIndex = 4;
            // 
            // removeCombatButton
            // 
            this.removeCombatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCombatButton.Location = new System.Drawing.Point(133, 606);
            this.removeCombatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeCombatButton.Name = "removeCombatButton";
            this.removeCombatButton.Size = new System.Drawing.Size(121, 57);
            this.removeCombatButton.TabIndex = 3;
            this.removeCombatButton.Text = "Remove Selected";
            this.removeCombatButton.UseVisualStyleBackColor = true;
            this.removeCombatButton.Click += new System.EventHandler(this.removeCombatButton_Click);
            // 
            // addCombatButton
            // 
            this.addCombatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCombatButton.Location = new System.Drawing.Point(133, 543);
            this.addCombatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCombatButton.Name = "addCombatButton";
            this.addCombatButton.Size = new System.Drawing.Size(121, 57);
            this.addCombatButton.TabIndex = 2;
            this.addCombatButton.Text = "Add Creature";
            this.addCombatButton.UseVisualStyleBackColor = true;
            this.addCombatButton.Click += new System.EventHandler(this.addCombatButton_Click);
            // 
            // combatListView
            // 
            this.combatListView.AllColumns.Add(this.olvColumn7);
            this.combatListView.AllColumns.Add(this.olvColumn5);
            this.combatListView.AllColumns.Add(this.olvColumn2);
            this.combatListView.AllColumns.Add(this.olvColumn8);
            this.combatListView.AllColumns.Add(this.olvColumn14);
            this.combatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combatListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.combatListView.CellEditUseWholeCell = false;
            this.combatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn5,
            this.olvColumn2,
            this.olvColumn8,
            this.olvColumn14});
            this.combatListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.combatListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatListView.GridLines = true;
            this.combatListView.Location = new System.Drawing.Point(5, 6);
            this.combatListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatListView.Name = "combatListView";
            this.combatListView.ShowGroups = false;
            this.combatListView.Size = new System.Drawing.Size(900, 533);
            this.combatListView.TabIndex = 1;
            this.combatListView.UseCompatibleStateImageBehavior = false;
            this.combatListView.View = System.Windows.Forms.View.Details;
            this.combatListView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.combatListView_FormatRow);
            this.combatListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.combatListView_KeyUp);
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Name";
            this.olvColumn7.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn7.Text = "Name";
            this.olvColumn7.Width = 200;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Initiative";
            this.olvColumn5.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn5.Text = "Initiative";
            this.olvColumn5.Width = 117;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "CurrentHP";
            this.olvColumn2.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn2.Text = "Current HP";
            this.olvColumn2.Width = 141;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "MaxHP";
            this.olvColumn8.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn8.Text = "Max HP";
            this.olvColumn8.Width = 125;
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "ArmorClass";
            this.olvColumn14.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn14.Text = "AC";
            // 
            // npcView
            // 
            this.npcView.Controls.Add(this.npcTalentLabel);
            this.npcView.Controls.Add(this.npcFlawLabel);
            this.npcView.Controls.Add(this.npcInteractionLabel);
            this.npcView.Controls.Add(this.npcMannerismLabel);
            this.npcView.Controls.Add(this.npcNameLabel);
            this.npcView.Controls.Add(this.npcSexLabel);
            this.npcView.Controls.Add(this.npcRaceLabel);
            this.npcView.Controls.Add(this.npcLocationLabel);
            this.npcView.Controls.Add(this.npcAppearanceLabel);
            this.npcView.Controls.Add(this.label48);
            this.npcView.Controls.Add(this.label46);
            this.npcView.Controls.Add(this.label47);
            this.npcView.Controls.Add(this.label45);
            this.npcView.Controls.Add(this.label43);
            this.npcView.Controls.Add(this.label41);
            this.npcView.Controls.Add(this.label39);
            this.npcView.Controls.Add(this.label37);
            this.npcView.Controls.Add(this.label33);
            this.npcView.Controls.Add(this.label27);
            this.npcView.Controls.Add(this.label26);
            this.npcView.Controls.Add(this.label24);
            this.npcView.Controls.Add(this.npcLocationTextBox);
            this.npcView.Controls.Add(this.label25);
            this.npcView.Controls.Add(this.npcRaceTextBox);
            this.npcView.Controls.Add(this.npcSexTextBox);
            this.npcView.Controls.Add(this.npcNameTextBox);
            this.npcView.Controls.Add(this.removeNPCButton);
            this.npcView.Controls.Add(this.addNPCButton);
            this.npcView.Controls.Add(this.label18);
            this.npcView.Controls.Add(this.npcBiographyRichTextBox);
            this.npcView.Controls.Add(this.npcListView);
            this.npcView.Location = new System.Drawing.Point(4, 64);
            this.npcView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcView.Name = "npcView";
            this.npcView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcView.Size = new System.Drawing.Size(912, 671);
            this.npcView.TabIndex = 2;
            this.npcView.Text = "NPC Tracker";
            this.npcView.UseVisualStyleBackColor = true;
            // 
            // npcTalentLabel
            // 
            this.npcTalentLabel.AutoSize = true;
            this.npcTalentLabel.Location = new System.Drawing.Point(678, 170);
            this.npcTalentLabel.Name = "npcTalentLabel";
            this.npcTalentLabel.Size = new System.Drawing.Size(13, 18);
            this.npcTalentLabel.TabIndex = 47;
            this.npcTalentLabel.Text = "-";
            // 
            // npcFlawLabel
            // 
            this.npcFlawLabel.AutoSize = true;
            this.npcFlawLabel.Location = new System.Drawing.Point(678, 152);
            this.npcFlawLabel.Name = "npcFlawLabel";
            this.npcFlawLabel.Size = new System.Drawing.Size(13, 18);
            this.npcFlawLabel.TabIndex = 46;
            this.npcFlawLabel.Text = "-";
            // 
            // npcInteractionLabel
            // 
            this.npcInteractionLabel.AutoSize = true;
            this.npcInteractionLabel.Location = new System.Drawing.Point(678, 134);
            this.npcInteractionLabel.Name = "npcInteractionLabel";
            this.npcInteractionLabel.Size = new System.Drawing.Size(13, 18);
            this.npcInteractionLabel.TabIndex = 45;
            this.npcInteractionLabel.Text = "-";
            // 
            // npcMannerismLabel
            // 
            this.npcMannerismLabel.AutoSize = true;
            this.npcMannerismLabel.Location = new System.Drawing.Point(678, 116);
            this.npcMannerismLabel.Name = "npcMannerismLabel";
            this.npcMannerismLabel.Size = new System.Drawing.Size(13, 18);
            this.npcMannerismLabel.TabIndex = 44;
            this.npcMannerismLabel.Text = "-";
            // 
            // npcNameLabel
            // 
            this.npcNameLabel.AutoSize = true;
            this.npcNameLabel.Location = new System.Drawing.Point(678, 6);
            this.npcNameLabel.Name = "npcNameLabel";
            this.npcNameLabel.Size = new System.Drawing.Size(13, 18);
            this.npcNameLabel.TabIndex = 43;
            this.npcNameLabel.Text = "-";
            // 
            // npcSexLabel
            // 
            this.npcSexLabel.AutoSize = true;
            this.npcSexLabel.Location = new System.Drawing.Point(678, 24);
            this.npcSexLabel.Name = "npcSexLabel";
            this.npcSexLabel.Size = new System.Drawing.Size(13, 18);
            this.npcSexLabel.TabIndex = 42;
            this.npcSexLabel.Text = "-";
            // 
            // npcRaceLabel
            // 
            this.npcRaceLabel.AutoSize = true;
            this.npcRaceLabel.Location = new System.Drawing.Point(678, 42);
            this.npcRaceLabel.Name = "npcRaceLabel";
            this.npcRaceLabel.Size = new System.Drawing.Size(13, 18);
            this.npcRaceLabel.TabIndex = 41;
            this.npcRaceLabel.Text = "-";
            // 
            // npcLocationLabel
            // 
            this.npcLocationLabel.AutoSize = true;
            this.npcLocationLabel.Location = new System.Drawing.Point(678, 60);
            this.npcLocationLabel.Name = "npcLocationLabel";
            this.npcLocationLabel.Size = new System.Drawing.Size(13, 18);
            this.npcLocationLabel.TabIndex = 40;
            this.npcLocationLabel.Text = "-";
            // 
            // npcAppearanceLabel
            // 
            this.npcAppearanceLabel.AutoSize = true;
            this.npcAppearanceLabel.Location = new System.Drawing.Point(678, 98);
            this.npcAppearanceLabel.Name = "npcAppearanceLabel";
            this.npcAppearanceLabel.Size = new System.Drawing.Size(13, 18);
            this.npcAppearanceLabel.TabIndex = 39;
            this.npcAppearanceLabel.Text = "-";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(459, 170);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(52, 18);
            this.label48.TabIndex = 38;
            this.label48.Text = "Talent:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(459, 152);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 18);
            this.label46.TabIndex = 37;
            this.label46.Text = "Flaw/Secret:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(459, 134);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(116, 18);
            this.label47.TabIndex = 36;
            this.label47.Text = "Interaction Style:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(459, 116);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(86, 18);
            this.label45.TabIndex = 35;
            this.label45.Text = "Mannerism:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(459, 98);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(90, 18);
            this.label43.TabIndex = 34;
            this.label43.Text = "Appearance:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(459, 60);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 18);
            this.label41.TabIndex = 33;
            this.label41.Text = "Location:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(459, 42);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 18);
            this.label39.TabIndex = 32;
            this.label39.Text = "Race:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(459, 24);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(37, 18);
            this.label37.TabIndex = 31;
            this.label37.Text = "Sex:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(459, 6);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 18);
            this.label33.TabIndex = 30;
            this.label33.Text = "Name:";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(382, 571);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 29);
            this.label27.TabIndex = 29;
            this.label27.Text = "Sex";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(189, 571);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 29);
            this.label26.TabIndex = 28;
            this.label26.Text = "Name";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(636, 571);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 29);
            this.label24.TabIndex = 27;
            this.label24.Text = "Location";
            // 
            // npcLocationTextBox
            // 
            this.npcLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.npcLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcLocationTextBox.Location = new System.Drawing.Point(616, 531);
            this.npcLocationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcLocationTextBox.Name = "npcLocationTextBox";
            this.npcLocationTextBox.Size = new System.Drawing.Size(152, 38);
            this.npcLocationTextBox.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(501, 570);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 29);
            this.label25.TabIndex = 25;
            this.label25.Text = "Race";
            // 
            // npcRaceTextBox
            // 
            this.npcRaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.npcRaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcRaceTextBox.Location = new System.Drawing.Point(458, 530);
            this.npcRaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcRaceTextBox.Name = "npcRaceTextBox";
            this.npcRaceTextBox.Size = new System.Drawing.Size(152, 38);
            this.npcRaceTextBox.TabIndex = 24;
            // 
            // npcSexTextBox
            // 
            this.npcSexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.npcSexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcSexTextBox.Location = new System.Drawing.Point(370, 530);
            this.npcSexTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcSexTextBox.Name = "npcSexTextBox";
            this.npcSexTextBox.Size = new System.Drawing.Size(82, 38);
            this.npcSexTextBox.TabIndex = 23;
            // 
            // npcNameTextBox
            // 
            this.npcNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.npcNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcNameTextBox.Location = new System.Drawing.Point(134, 530);
            this.npcNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcNameTextBox.Name = "npcNameTextBox";
            this.npcNameTextBox.Size = new System.Drawing.Size(231, 38);
            this.npcNameTextBox.TabIndex = 22;
            // 
            // removeNPCButton
            // 
            this.removeNPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeNPCButton.Location = new System.Drawing.Point(6, 582);
            this.removeNPCButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeNPCButton.Name = "removeNPCButton";
            this.removeNPCButton.Size = new System.Drawing.Size(121, 57);
            this.removeNPCButton.TabIndex = 21;
            this.removeNPCButton.Text = "Remove Selected";
            this.removeNPCButton.UseVisualStyleBackColor = true;
            this.removeNPCButton.Click += new System.EventHandler(this.removeNPCButton_Click);
            // 
            // addNPCButton
            // 
            this.addNPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNPCButton.Location = new System.Drawing.Point(6, 519);
            this.addNPCButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNPCButton.Name = "addNPCButton";
            this.addNPCButton.Size = new System.Drawing.Size(121, 57);
            this.addNPCButton.TabIndex = 20;
            this.addNPCButton.Text = "Add NPC";
            this.addNPCButton.UseVisualStyleBackColor = true;
            this.addNPCButton.Click += new System.EventHandler(this.addNPCButton_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(619, 491);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Biography";
            // 
            // npcBiographyRichTextBox
            // 
            this.npcBiographyRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npcBiographyRichTextBox.Location = new System.Drawing.Point(458, 191);
            this.npcBiographyRichTextBox.Name = "npcBiographyRichTextBox";
            this.npcBiographyRichTextBox.Size = new System.Drawing.Size(448, 297);
            this.npcBiographyRichTextBox.TabIndex = 1;
            this.npcBiographyRichTextBox.Text = "";
            // 
            // npcListView
            // 
            this.npcListView.AllColumns.Add(this.olvColumn1);
            this.npcListView.AllColumns.Add(this.olvColumn13);
            this.npcListView.AllColumns.Add(this.olvColumn3);
            this.npcListView.AllColumns.Add(this.olvColumn4);
            this.npcListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.npcListView.CellEditUseWholeCell = false;
            this.npcListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn13,
            this.olvColumn3,
            this.olvColumn4});
            this.npcListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.npcListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcListView.GridLines = true;
            this.npcListView.Location = new System.Drawing.Point(6, 5);
            this.npcListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcListView.Name = "npcListView";
            this.npcListView.ShowGroups = false;
            this.npcListView.Size = new System.Drawing.Size(446, 483);
            this.npcListView.TabIndex = 0;
            this.npcListView.UseCompatibleStateImageBehavior = false;
            this.npcListView.View = System.Windows.Forms.View.Details;
            this.npcListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.npcListView_ItemSelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 157;
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Sex";
            this.olvColumn13.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn13.Text = "Sex";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Race";
            this.olvColumn3.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn3.Text = "Race";
            this.olvColumn3.Width = 111;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Location";
            this.olvColumn4.HeaderFont = new System.Drawing.Font("Matura MT Script Capitals", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn4.Text = "Location";
            this.olvColumn4.Width = 113;
            // 
            // generatorView
            // 
            this.generatorView.Controls.Add(this.generatorTabControl);
            this.generatorView.Location = new System.Drawing.Point(4, 64);
            this.generatorView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatorView.Name = "generatorView";
            this.generatorView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatorView.Size = new System.Drawing.Size(912, 671);
            this.generatorView.TabIndex = 3;
            this.generatorView.Text = "Generators";
            this.generatorView.UseVisualStyleBackColor = true;
            // 
            // generatorTabControl
            // 
            this.generatorTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatorTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.generatorTabControl.Controls.Add(this.tabPage1);
            this.generatorTabControl.Controls.Add(this.tabPage5);
            this.generatorTabControl.Controls.Add(this.tabPage6);
            this.generatorTabControl.Controls.Add(this.tabPage4);
            this.generatorTabControl.Controls.Add(this.tabPage7);
            this.generatorTabControl.ItemSize = new System.Drawing.Size(140, 40);
            this.generatorTabControl.Location = new System.Drawing.Point(7, 6);
            this.generatorTabControl.Name = "generatorTabControl";
            this.generatorTabControl.SelectedIndex = 0;
            this.generatorTabControl.Size = new System.Drawing.Size(899, 660);
            this.generatorTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.generatorTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.talentLabel);
            this.tabPage1.Controls.Add(this.flawLabel);
            this.tabPage1.Controls.Add(this.interactionLabel);
            this.tabPage1.Controls.Add(this.mannerismLabel);
            this.tabPage1.Controls.Add(this.appearanceLabel);
            this.tabPage1.Controls.Add(this.lastNameLabel);
            this.tabPage1.Controls.Add(this.firstNameLabel);
            this.tabPage1.Controls.Add(this.createNPCButton);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.allTraitsButton);
            this.tabPage1.Controls.Add(this.talentButton);
            this.tabPage1.Controls.Add(this.flawButton);
            this.tabPage1.Controls.Add(this.interactionButton);
            this.tabPage1.Controls.Add(this.mannerismButton);
            this.tabPage1.Controls.Add(this.appearanceButton);
            this.tabPage1.Controls.Add(this.rollFullNameButton);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.generatorLocationTextBox);
            this.tabPage1.Controls.Add(this.saveNPCButton);
            this.tabPage1.Controls.Add(this.rollLastNameButton);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.rollFirstNameButton);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.npcBioRichTextBox);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.genderComboBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.raceComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NPC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // talentLabel
            // 
            this.talentLabel.Location = new System.Drawing.Point(157, 257);
            this.talentLabel.Name = "talentLabel";
            this.talentLabel.Size = new System.Drawing.Size(191, 24);
            this.talentLabel.TabIndex = 48;
            // 
            // flawLabel
            // 
            this.flawLabel.Location = new System.Drawing.Point(157, 197);
            this.flawLabel.Name = "flawLabel";
            this.flawLabel.Size = new System.Drawing.Size(191, 24);
            this.flawLabel.TabIndex = 47;
            // 
            // interactionLabel
            // 
            this.interactionLabel.Location = new System.Drawing.Point(157, 227);
            this.interactionLabel.Name = "interactionLabel";
            this.interactionLabel.Size = new System.Drawing.Size(191, 24);
            this.interactionLabel.TabIndex = 46;
            // 
            // mannerismLabel
            // 
            this.mannerismLabel.Location = new System.Drawing.Point(157, 167);
            this.mannerismLabel.Name = "mannerismLabel";
            this.mannerismLabel.Size = new System.Drawing.Size(191, 24);
            this.mannerismLabel.TabIndex = 45;
            // 
            // appearanceLabel
            // 
            this.appearanceLabel.Location = new System.Drawing.Point(157, 137);
            this.appearanceLabel.Name = "appearanceLabel";
            this.appearanceLabel.Size = new System.Drawing.Size(191, 24);
            this.appearanceLabel.TabIndex = 44;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(157, 107);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(191, 24);
            this.lastNameLabel.TabIndex = 43;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(157, 77);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(191, 24);
            this.firstNameLabel.TabIndex = 42;
            // 
            // createNPCButton
            // 
            this.createNPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createNPCButton.Location = new System.Drawing.Point(164, 554);
            this.createNPCButton.Name = "createNPCButton";
            this.createNPCButton.Size = new System.Drawing.Size(108, 52);
            this.createNPCButton.TabIndex = 38;
            this.createNPCButton.Text = "Roll Entire NPC";
            this.createNPCButton.UseVisualStyleBackColor = true;
            this.createNPCButton.Click += new System.EventHandler(this.createNPCButton_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 261);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(60, 20);
            this.label44.TabIndex = 36;
            this.label44.Text = "Talent:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(6, 199);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(103, 20);
            this.label40.TabIndex = 34;
            this.label40.Text = "Flaw/Secret:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(6, 229);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(134, 20);
            this.label42.TabIndex = 32;
            this.label42.Text = "Interaction Style:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(6, 169);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(97, 20);
            this.label38.TabIndex = 30;
            this.label38.Text = "Mannerism:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 139);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(103, 20);
            this.label36.TabIndex = 28;
            this.label36.Text = "Appearance:";
            // 
            // allTraitsButton
            // 
            this.allTraitsButton.Location = new System.Drawing.Point(237, 410);
            this.allTraitsButton.Name = "allTraitsButton";
            this.allTraitsButton.Size = new System.Drawing.Size(108, 52);
            this.allTraitsButton.TabIndex = 27;
            this.allTraitsButton.Text = "Roll All Traits";
            this.allTraitsButton.UseVisualStyleBackColor = true;
            this.allTraitsButton.Click += new System.EventHandler(this.allTraitsButton_Click);
            // 
            // talentButton
            // 
            this.talentButton.Location = new System.Drawing.Point(124, 410);
            this.talentButton.Name = "talentButton";
            this.talentButton.Size = new System.Drawing.Size(108, 52);
            this.talentButton.TabIndex = 26;
            this.talentButton.Text = "Roll Talent";
            this.talentButton.UseVisualStyleBackColor = true;
            this.talentButton.Click += new System.EventHandler(this.talentButton_Click);
            // 
            // flawButton
            // 
            this.flawButton.Location = new System.Drawing.Point(10, 410);
            this.flawButton.Name = "flawButton";
            this.flawButton.Size = new System.Drawing.Size(108, 52);
            this.flawButton.TabIndex = 25;
            this.flawButton.Text = "Roll Flaw/Secret";
            this.flawButton.UseVisualStyleBackColor = true;
            this.flawButton.Click += new System.EventHandler(this.flawButton_Click);
            // 
            // interactionButton
            // 
            this.interactionButton.Location = new System.Drawing.Point(237, 352);
            this.interactionButton.Name = "interactionButton";
            this.interactionButton.Size = new System.Drawing.Size(108, 52);
            this.interactionButton.TabIndex = 24;
            this.interactionButton.Text = "Roll Interaction";
            this.interactionButton.UseVisualStyleBackColor = true;
            this.interactionButton.Click += new System.EventHandler(this.interactionButton_Click);
            // 
            // mannerismButton
            // 
            this.mannerismButton.Location = new System.Drawing.Point(124, 352);
            this.mannerismButton.Name = "mannerismButton";
            this.mannerismButton.Size = new System.Drawing.Size(108, 52);
            this.mannerismButton.TabIndex = 23;
            this.mannerismButton.Text = "Roll Mannerism";
            this.mannerismButton.UseVisualStyleBackColor = true;
            this.mannerismButton.Click += new System.EventHandler(this.mannerismButton_Click);
            // 
            // appearanceButton
            // 
            this.appearanceButton.Location = new System.Drawing.Point(10, 352);
            this.appearanceButton.Name = "appearanceButton";
            this.appearanceButton.Size = new System.Drawing.Size(108, 52);
            this.appearanceButton.TabIndex = 22;
            this.appearanceButton.Text = "Roll Appearance";
            this.appearanceButton.UseVisualStyleBackColor = true;
            this.appearanceButton.Click += new System.EventHandler(this.appearanceButton_Click);
            // 
            // rollFullNameButton
            // 
            this.rollFullNameButton.Location = new System.Drawing.Point(237, 294);
            this.rollFullNameButton.Name = "rollFullNameButton";
            this.rollFullNameButton.Size = new System.Drawing.Size(108, 52);
            this.rollFullNameButton.TabIndex = 21;
            this.rollFullNameButton.Text = "Roll Full Name";
            this.rollFullNameButton.UseVisualStyleBackColor = true;
            this.rollFullNameButton.Click += new System.EventHandler(this.rollFullNameButton_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(178, 517);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "Location";
            // 
            // generatorLocationTextBox
            // 
            this.generatorLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generatorLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatorLocationTextBox.Location = new System.Drawing.Point(6, 505);
            this.generatorLocationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatorLocationTextBox.Name = "generatorLocationTextBox";
            this.generatorLocationTextBox.Size = new System.Drawing.Size(152, 38);
            this.generatorLocationTextBox.TabIndex = 19;
            // 
            // saveNPCButton
            // 
            this.saveNPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveNPCButton.Location = new System.Drawing.Point(6, 554);
            this.saveNPCButton.Name = "saveNPCButton";
            this.saveNPCButton.Size = new System.Drawing.Size(152, 52);
            this.saveNPCButton.TabIndex = 12;
            this.saveNPCButton.Text = "Save NPC";
            this.saveNPCButton.UseVisualStyleBackColor = true;
            this.saveNPCButton.Click += new System.EventHandler(this.saveNPCButton_Click);
            // 
            // rollLastNameButton
            // 
            this.rollLastNameButton.Location = new System.Drawing.Point(124, 294);
            this.rollLastNameButton.Name = "rollLastNameButton";
            this.rollLastNameButton.Size = new System.Drawing.Size(108, 52);
            this.rollLastNameButton.TabIndex = 11;
            this.rollLastNameButton.Text = "Roll Last Name";
            this.rollLastNameButton.UseVisualStyleBackColor = true;
            this.rollLastNameButton.Click += new System.EventHandler(this.rollLastNameButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Last Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "First Name:";
            // 
            // rollFirstNameButton
            // 
            this.rollFirstNameButton.Location = new System.Drawing.Point(10, 294);
            this.rollFirstNameButton.Name = "rollFirstNameButton";
            this.rollFirstNameButton.Size = new System.Drawing.Size(108, 52);
            this.rollFirstNameButton.TabIndex = 6;
            this.rollFirstNameButton.Text = "Roll First Name";
            this.rollFirstNameButton.UseVisualStyleBackColor = true;
            this.rollFirstNameButton.Click += new System.EventHandler(this.rollFirstNameButton_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(585, 497);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Biography";
            // 
            // npcBioRichTextBox
            // 
            this.npcBioRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npcBioRichTextBox.Location = new System.Drawing.Point(354, 6);
            this.npcBioRichTextBox.Name = "npcBioRichTextBox";
            this.npcBioRichTextBox.Size = new System.Drawing.Size(531, 488);
            this.npcBioRichTextBox.TabIndex = 4;
            this.npcBioRichTextBox.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(157, 8);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(191, 26);
            this.genderComboBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Race:";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Human",
            "Elven",
            "Dwarven",
            "Halfling",
            "Gnomish",
            "Gnoll"});
            this.raceComboBox.Location = new System.Drawing.Point(157, 40);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(191, 26);
            this.raceComboBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.settlementRaceTextBox);
            this.tabPage5.Controls.Add(this.label52);
            this.tabPage5.Controls.Add(this.rollSettlementButton);
            this.tabPage5.Controls.Add(this.settlementCurrentCalamityTextBox);
            this.tabPage5.Controls.Add(this.settlementKnownForTextBox);
            this.tabPage5.Controls.Add(this.settlementNotableTraitTextBox);
            this.tabPage5.Controls.Add(this.settlementRulerStatusTextBox);
            this.tabPage5.Controls.Add(this.settlementRaceRelationsTextBox);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.settlementNameTextBox);
            this.tabPage5.Controls.Add(this.label55);
            this.tabPage5.Controls.Add(this.label57);
            this.tabPage5.Controls.Add(this.label59);
            this.tabPage5.Controls.Add(this.label61);
            this.tabPage5.Controls.Add(this.label63);
            this.tabPage5.Controls.Add(this.rollSettlementTraitsButton);
            this.tabPage5.Controls.Add(this.rollSettlementNameButton);
            this.tabPage5.Controls.Add(this.rollSettlementRulerStatusButton);
            this.tabPage5.Controls.Add(this.rollSettlementRelationsButton);
            this.tabPage5.Controls.Add(this.rollSettlementCalamityButton);
            this.tabPage5.Controls.Add(this.rollSettlementKnownForButton);
            this.tabPage5.Controls.Add(this.settlementCountryTextBox);
            this.tabPage5.Controls.Add(this.saveSettlementButton);
            this.tabPage5.Controls.Add(this.label66);
            this.tabPage5.Controls.Add(this.settlementDescriptionRichTextBox);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.rollSettlementNotableTraitButton);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.settlementTypeComboBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(891, 612);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settlement";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // settlementRaceTextBox
            // 
            this.settlementRaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settlementRaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementRaceTextBox.Location = new System.Drawing.Point(81, 497);
            this.settlementRaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settlementRaceTextBox.Name = "settlementRaceTextBox";
            this.settlementRaceTextBox.Size = new System.Drawing.Size(199, 24);
            this.settlementRaceTextBox.TabIndex = 73;
            // 
            // label52
            // 
            this.label52.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(3, 499);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 20);
            this.label52.TabIndex = 72;
            this.label52.Tag = "c";
            this.label52.Text = "Race:";
            // 
            // rollSettlementButton
            // 
            this.rollSettlementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementButton.Location = new System.Drawing.Point(286, 497);
            this.rollSettlementButton.Name = "rollSettlementButton";
            this.rollSettlementButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementButton.TabIndex = 71;
            this.rollSettlementButton.Text = "Roll Settlement";
            this.rollSettlementButton.UseVisualStyleBackColor = true;
            this.rollSettlementButton.Click += new System.EventHandler(this.rollSettlementButton_Click);
            // 
            // settlementCurrentCalamityTextBox
            // 
            this.settlementCurrentCalamityTextBox.Location = new System.Drawing.Point(164, 194);
            this.settlementCurrentCalamityTextBox.Name = "settlementCurrentCalamityTextBox";
            this.settlementCurrentCalamityTextBox.Size = new System.Drawing.Size(721, 24);
            this.settlementCurrentCalamityTextBox.TabIndex = 70;
            // 
            // settlementKnownForTextBox
            // 
            this.settlementKnownForTextBox.Location = new System.Drawing.Point(164, 164);
            this.settlementKnownForTextBox.Name = "settlementKnownForTextBox";
            this.settlementKnownForTextBox.Size = new System.Drawing.Size(721, 24);
            this.settlementKnownForTextBox.TabIndex = 69;
            // 
            // settlementNotableTraitTextBox
            // 
            this.settlementNotableTraitTextBox.Location = new System.Drawing.Point(164, 134);
            this.settlementNotableTraitTextBox.Name = "settlementNotableTraitTextBox";
            this.settlementNotableTraitTextBox.Size = new System.Drawing.Size(721, 24);
            this.settlementNotableTraitTextBox.TabIndex = 68;
            // 
            // settlementRulerStatusTextBox
            // 
            this.settlementRulerStatusTextBox.Location = new System.Drawing.Point(164, 104);
            this.settlementRulerStatusTextBox.Name = "settlementRulerStatusTextBox";
            this.settlementRulerStatusTextBox.Size = new System.Drawing.Size(721, 24);
            this.settlementRulerStatusTextBox.TabIndex = 67;
            // 
            // settlementRaceRelationsTextBox
            // 
            this.settlementRaceRelationsTextBox.Location = new System.Drawing.Point(164, 74);
            this.settlementRaceRelationsTextBox.Name = "settlementRaceRelationsTextBox";
            this.settlementRaceRelationsTextBox.Size = new System.Drawing.Size(721, 24);
            this.settlementRaceRelationsTextBox.TabIndex = 66;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 525);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 20);
            this.label29.TabIndex = 65;
            this.label29.Tag = "c";
            this.label29.Text = "Country:";
            // 
            // settlementNameTextBox
            // 
            this.settlementNameTextBox.Location = new System.Drawing.Point(163, 44);
            this.settlementNameTextBox.Name = "settlementNameTextBox";
            this.settlementNameTextBox.Size = new System.Drawing.Size(722, 24);
            this.settlementNameTextBox.TabIndex = 64;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(8, 196);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(135, 20);
            this.label55.TabIndex = 62;
            this.label55.Text = "Current Calamity";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(8, 166);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(94, 20);
            this.label57.TabIndex = 60;
            this.label57.Text = "Known For:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(8, 136);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(110, 20);
            this.label59.TabIndex = 58;
            this.label59.Text = "Notable Trait:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(8, 106);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(120, 20);
            this.label61.TabIndex = 56;
            this.label61.Text = "Ruler\'s Status:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(8, 76);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(128, 20);
            this.label63.TabIndex = 54;
            this.label63.Text = "Race Relations:";
            // 
            // rollSettlementTraitsButton
            // 
            this.rollSettlementTraitsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementTraitsButton.Location = new System.Drawing.Point(400, 497);
            this.rollSettlementTraitsButton.Name = "rollSettlementTraitsButton";
            this.rollSettlementTraitsButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementTraitsButton.TabIndex = 53;
            this.rollSettlementTraitsButton.Text = "Roll All Traits";
            this.rollSettlementTraitsButton.UseVisualStyleBackColor = true;
            this.rollSettlementTraitsButton.Click += new System.EventHandler(this.rollSettlementTraitsButton_Click);
            // 
            // rollSettlementNameButton
            // 
            this.rollSettlementNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementNameButton.Location = new System.Drawing.Point(285, 552);
            this.rollSettlementNameButton.Name = "rollSettlementNameButton";
            this.rollSettlementNameButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementNameButton.TabIndex = 52;
            this.rollSettlementNameButton.Text = "Roll Name";
            this.rollSettlementNameButton.UseVisualStyleBackColor = true;
            this.rollSettlementNameButton.Click += new System.EventHandler(this.rollSettlementNameButton_Click);
            // 
            // rollSettlementRulerStatusButton
            // 
            this.rollSettlementRulerStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementRulerStatusButton.Location = new System.Drawing.Point(514, 497);
            this.rollSettlementRulerStatusButton.Name = "rollSettlementRulerStatusButton";
            this.rollSettlementRulerStatusButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementRulerStatusButton.TabIndex = 51;
            this.rollSettlementRulerStatusButton.Text = "Roll Ruler Status";
            this.rollSettlementRulerStatusButton.UseVisualStyleBackColor = true;
            this.rollSettlementRulerStatusButton.Click += new System.EventHandler(this.rollSettlementRulerStatusButton_Click);
            // 
            // rollSettlementRelationsButton
            // 
            this.rollSettlementRelationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementRelationsButton.Location = new System.Drawing.Point(400, 552);
            this.rollSettlementRelationsButton.Name = "rollSettlementRelationsButton";
            this.rollSettlementRelationsButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementRelationsButton.TabIndex = 50;
            this.rollSettlementRelationsButton.Text = "Roll Race Relations";
            this.rollSettlementRelationsButton.UseVisualStyleBackColor = true;
            this.rollSettlementRelationsButton.Click += new System.EventHandler(this.rollSettlementRelationsButton_Click);
            // 
            // rollSettlementCalamityButton
            // 
            this.rollSettlementCalamityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementCalamityButton.Location = new System.Drawing.Point(628, 497);
            this.rollSettlementCalamityButton.Name = "rollSettlementCalamityButton";
            this.rollSettlementCalamityButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementCalamityButton.TabIndex = 49;
            this.rollSettlementCalamityButton.Text = "Roll Calamity";
            this.rollSettlementCalamityButton.UseVisualStyleBackColor = true;
            this.rollSettlementCalamityButton.Click += new System.EventHandler(this.rollSettlementCalamityButton_Click);
            // 
            // rollSettlementKnownForButton
            // 
            this.rollSettlementKnownForButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementKnownForButton.Location = new System.Drawing.Point(628, 552);
            this.rollSettlementKnownForButton.Name = "rollSettlementKnownForButton";
            this.rollSettlementKnownForButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementKnownForButton.TabIndex = 48;
            this.rollSettlementKnownForButton.Text = "Roll Known For";
            this.rollSettlementKnownForButton.UseVisualStyleBackColor = true;
            this.rollSettlementKnownForButton.Click += new System.EventHandler(this.rollSettlementKnownForButton_Click);
            // 
            // settlementCountryTextBox
            // 
            this.settlementCountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settlementCountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementCountryTextBox.Location = new System.Drawing.Point(81, 525);
            this.settlementCountryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settlementCountryTextBox.Name = "settlementCountryTextBox";
            this.settlementCountryTextBox.Size = new System.Drawing.Size(199, 24);
            this.settlementCountryTextBox.TabIndex = 46;
            // 
            // saveSettlementButton
            // 
            this.saveSettlementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveSettlementButton.Location = new System.Drawing.Point(6, 554);
            this.saveSettlementButton.Name = "saveSettlementButton";
            this.saveSettlementButton.Size = new System.Drawing.Size(274, 52);
            this.saveSettlementButton.TabIndex = 45;
            this.saveSettlementButton.Text = "Save Settlement";
            this.saveSettlementButton.UseVisualStyleBackColor = true;
            this.saveSettlementButton.Click += new System.EventHandler(this.saveSettlementButton_Click);
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(368, 463);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(95, 20);
            this.label66.TabIndex = 40;
            this.label66.Tag = "c";
            this.label66.Text = "Description";
            // 
            // settlementDescriptionRichTextBox
            // 
            this.settlementDescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settlementDescriptionRichTextBox.Location = new System.Drawing.Point(6, 224);
            this.settlementDescriptionRichTextBox.Name = "settlementDescriptionRichTextBox";
            this.settlementDescriptionRichTextBox.Size = new System.Drawing.Size(879, 236);
            this.settlementDescriptionRichTextBox.TabIndex = 39;
            this.settlementDescriptionRichTextBox.Text = "";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 20);
            this.label30.TabIndex = 15;
            this.label30.Text = "Name:";
            // 
            // rollSettlementNotableTraitButton
            // 
            this.rollSettlementNotableTraitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollSettlementNotableTraitButton.Location = new System.Drawing.Point(514, 552);
            this.rollSettlementNotableTraitButton.Name = "rollSettlementNotableTraitButton";
            this.rollSettlementNotableTraitButton.Size = new System.Drawing.Size(108, 52);
            this.rollSettlementNotableTraitButton.TabIndex = 14;
            this.rollSettlementNotableTraitButton.Text = "Roll Notable Trait";
            this.rollSettlementNotableTraitButton.UseVisualStyleBackColor = true;
            this.rollSettlementNotableTraitButton.Click += new System.EventHandler(this.rollSettlementNotableTraitButton_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(8, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 20);
            this.label31.TabIndex = 13;
            this.label31.Text = "Type:";
            // 
            // settlementTypeComboBox
            // 
            this.settlementTypeComboBox.FormattingEnabled = true;
            this.settlementTypeComboBox.Items.AddRange(new object[] {
            "Castle",
            "Tower",
            "City",
            "Town",
            "Village"});
            this.settlementTypeComboBox.Location = new System.Drawing.Point(163, 12);
            this.settlementTypeComboBox.Name = "settlementTypeComboBox";
            this.settlementTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.settlementTypeComboBox.TabIndex = 12;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.geographyNameLabel);
            this.tabPage6.Controls.Add(this.label34);
            this.tabPage6.Controls.Add(this.geographyButton);
            this.tabPage6.Controls.Add(this.label35);
            this.tabPage6.Controls.Add(this.geographyComboBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(891, 612);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Geography";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // geographyNameLabel
            // 
            this.geographyNameLabel.AutoSize = true;
            this.geographyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geographyNameLabel.Location = new System.Drawing.Point(84, 46);
            this.geographyNameLabel.Name = "geographyNameLabel";
            this.geographyNameLabel.Size = new System.Drawing.Size(15, 20);
            this.geographyNameLabel.TabIndex = 21;
            this.geographyNameLabel.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(3, 46);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 20);
            this.label34.TabIndex = 20;
            this.label34.Text = "Name:";
            // 
            // geographyButton
            // 
            this.geographyButton.Location = new System.Drawing.Point(7, 80);
            this.geographyButton.Name = "geographyButton";
            this.geographyButton.Size = new System.Drawing.Size(92, 52);
            this.geographyButton.TabIndex = 19;
            this.geographyButton.Text = "Roll Name";
            this.geographyButton.UseVisualStyleBackColor = true;
            this.geographyButton.Click += new System.EventHandler(this.geographyButton_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 10);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 20);
            this.label35.TabIndex = 18;
            this.label35.Text = "Type:";
            // 
            // geographyComboBox
            // 
            this.geographyComboBox.FormattingEnabled = true;
            this.geographyComboBox.Items.AddRange(new object[] {
            "Forest",
            "River",
            "Mountain",
            "Swamp",
            "Island"});
            this.geographyComboBox.Location = new System.Drawing.Point(88, 8);
            this.geographyComboBox.Name = "geographyComboBox";
            this.geographyComboBox.Size = new System.Drawing.Size(121, 26);
            this.geographyComboBox.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label56);
            this.tabPage4.Controls.Add(this.treasureTextBox);
            this.tabPage4.Controls.Add(this.treasureLabel);
            this.tabPage4.Controls.Add(this.label58);
            this.tabPage4.Controls.Add(this.rollTreasureButton);
            this.tabPage4.Controls.Add(this.label60);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(891, 612);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Treasure";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(6, 28);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(136, 20);
            this.label56.TabIndex = 27;
            this.label56.Text = "Example:  1,3,2,4";
            // 
            // treasureTextBox
            // 
            this.treasureTextBox.Location = new System.Drawing.Point(368, 7);
            this.treasureTextBox.Name = "treasureTextBox";
            this.treasureTextBox.Size = new System.Drawing.Size(163, 24);
            this.treasureTextBox.TabIndex = 26;
            // 
            // treasureLabel
            // 
            this.treasureLabel.AutoSize = true;
            this.treasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureLabel.Location = new System.Drawing.Point(127, 62);
            this.treasureLabel.Name = "treasureLabel";
            this.treasureLabel.Size = new System.Drawing.Size(15, 20);
            this.treasureLabel.TabIndex = 25;
            this.treasureLabel.Text = "-";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(6, 62);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(81, 20);
            this.label58.TabIndex = 24;
            this.label58.Text = "Treasure:";
            // 
            // rollTreasureButton
            // 
            this.rollTreasureButton.Location = new System.Drawing.Point(10, 85);
            this.rollTreasureButton.Name = "rollTreasureButton";
            this.rollTreasureButton.Size = new System.Drawing.Size(92, 52);
            this.rollTreasureButton.TabIndex = 23;
            this.rollTreasureButton.Text = "Roll Treasure";
            this.rollTreasureButton.UseVisualStyleBackColor = true;
            this.rollTreasureButton.Click += new System.EventHandler(this.rollTreasureButton_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(6, 8);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(314, 20);
            this.label60.TabIndex = 22;
            this.label60.Text = "Challenge Ratings (Separate w/ Comas):";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.magicItemShopListView);
            this.tabPage7.Controls.Add(this.generateShopButton);
            this.tabPage7.Controls.Add(this.label62);
            this.tabPage7.Controls.Add(this.magicItemShopQualityComboBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 44);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(891, 612);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Magic Shop";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // magicItemShopListView
            // 
            this.magicItemShopListView.AllColumns.Add(this.olvColumn20);
            this.magicItemShopListView.AllColumns.Add(this.olvColumn16);
            this.magicItemShopListView.AllColumns.Add(this.olvColumn17);
            this.magicItemShopListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.magicItemShopListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.magicItemShopListView.CellEditUseWholeCell = false;
            this.magicItemShopListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn20,
            this.olvColumn16,
            this.olvColumn17});
            this.magicItemShopListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.magicItemShopListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicItemShopListView.GridLines = true;
            this.magicItemShopListView.Location = new System.Drawing.Point(6, 5);
            this.magicItemShopListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magicItemShopListView.Name = "magicItemShopListView";
            this.magicItemShopListView.ShowGroups = false;
            this.magicItemShopListView.Size = new System.Drawing.Size(879, 512);
            this.magicItemShopListView.TabIndex = 23;
            this.magicItemShopListView.UseCompatibleStateImageBehavior = false;
            this.magicItemShopListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn20
            // 
            this.olvColumn20.AspectName = "Name";
            this.olvColumn20.MaximumWidth = 496;
            this.olvColumn20.MinimumWidth = 496;
            this.olvColumn20.Text = "Magic Item";
            this.olvColumn20.Width = 496;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "Rarity";
            this.olvColumn16.MaximumWidth = 239;
            this.olvColumn16.MinimumWidth = 239;
            this.olvColumn16.Text = "Rarity";
            this.olvColumn16.Width = 239;
            // 
            // olvColumn17
            // 
            this.olvColumn17.AspectName = "Value";
            this.olvColumn17.MaximumWidth = 212;
            this.olvColumn17.MinimumWidth = 212;
            this.olvColumn17.Text = "Value";
            this.olvColumn17.Width = 212;
            // 
            // generateShopButton
            // 
            this.generateShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateShopButton.Location = new System.Drawing.Point(6, 554);
            this.generateShopButton.Name = "generateShopButton";
            this.generateShopButton.Size = new System.Drawing.Size(98, 52);
            this.generateShopButton.TabIndex = 22;
            this.generateShopButton.Text = "Generate Shop";
            this.generateShopButton.UseVisualStyleBackColor = true;
            this.generateShopButton.Click += new System.EventHandler(this.generateShopButton_Click);
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(111, 567);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(66, 20);
            this.label62.TabIndex = 21;
            this.label62.Text = "Quality:";
            // 
            // magicItemShopQualityComboBox
            // 
            this.magicItemShopQualityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.magicItemShopQualityComboBox.FormattingEnabled = true;
            this.magicItemShopQualityComboBox.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Very Rare",
            "Legendary"});
            this.magicItemShopQualityComboBox.Location = new System.Drawing.Point(202, 562);
            this.magicItemShopQualityComboBox.Name = "magicItemShopQualityComboBox";
            this.magicItemShopQualityComboBox.Size = new System.Drawing.Size(109, 26);
            this.magicItemShopQualityComboBox.TabIndex = 20;
            // 
            // miscView
            // 
            this.miscView.Controls.Add(this.miscTabControl);
            this.miscView.Location = new System.Drawing.Point(4, 64);
            this.miscView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miscView.Name = "miscView";
            this.miscView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miscView.Size = new System.Drawing.Size(912, 671);
            this.miscView.TabIndex = 5;
            this.miscView.Text = "Misc Tools";
            this.miscView.UseVisualStyleBackColor = true;
            // 
            // miscTabControl
            // 
            this.miscTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.miscTabControl.Controls.Add(this.tabPage2);
            this.miscTabControl.Controls.Add(this.tabPage3);
            this.miscTabControl.ItemSize = new System.Drawing.Size(140, 40);
            this.miscTabControl.Location = new System.Drawing.Point(7, 5);
            this.miscTabControl.Name = "miscTabControl";
            this.miscTabControl.SelectedIndex = 0;
            this.miscTabControl.Size = new System.Drawing.Size(899, 632);
            this.miscTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.miscTabControl.TabIndex = 1;
            this.miscTabControl.SelectedIndexChanged += new System.EventHandler(this.miscTabControl_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.setFoodButton);
            this.tabPage2.Controls.Add(this.setFoodTextBox);
            this.tabPage2.Controls.Add(this.survivalNotesTextBox);
            this.tabPage2.Controls.Add(this.biomeLabel);
            this.tabPage2.Controls.Add(this.plainsRadioButton);
            this.tabPage2.Controls.Add(this.arcticRadioButton);
            this.tabPage2.Controls.Add(this.foodForagedLabel);
            this.tabPage2.Controls.Add(this.movementLabel);
            this.tabPage2.Controls.Add(this.decerementMovementButton);
            this.tabPage2.Controls.Add(this.incerementMovementButton);
            this.tabPage2.Controls.Add(this.decerementFoodButton);
            this.tabPage2.Controls.Add(this.incerementFoodButton);
            this.tabPage2.Controls.Add(this.daysWithoutFoodLabel);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.foodRemainingLabel);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.rationLevelComboBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.endDayButton);
            this.tabPage2.Controls.Add(this.weatherEffectLabel);
            this.tabPage2.Controls.Add(this.weatherLabel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 584);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Survival";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // survivalNotesTextBox
            // 
            this.survivalNotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.survivalNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivalNotesTextBox.Location = new System.Drawing.Point(289, 59);
            this.survivalNotesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.survivalNotesTextBox.Name = "survivalNotesTextBox";
            this.survivalNotesTextBox.Size = new System.Drawing.Size(595, 374);
            this.survivalNotesTextBox.TabIndex = 38;
            this.survivalNotesTextBox.Text = "";
            // 
            // biomeLabel
            // 
            this.biomeLabel.AutoSize = true;
            this.biomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biomeLabel.Location = new System.Drawing.Point(8, 115);
            this.biomeLabel.Name = "biomeLabel";
            this.biomeLabel.Size = new System.Drawing.Size(56, 18);
            this.biomeLabel.TabIndex = 37;
            this.biomeLabel.Text = "Biome";
            // 
            // plainsRadioButton
            // 
            this.plainsRadioButton.AutoSize = true;
            this.plainsRadioButton.Location = new System.Drawing.Point(11, 164);
            this.plainsRadioButton.Name = "plainsRadioButton";
            this.plainsRadioButton.Size = new System.Drawing.Size(69, 22);
            this.plainsRadioButton.TabIndex = 36;
            this.plainsRadioButton.Text = "Plains";
            this.plainsRadioButton.UseVisualStyleBackColor = true;
            this.plainsRadioButton.CheckedChanged += new System.EventHandler(this.plainsRadioButton_CheckedChanged);
            // 
            // arcticRadioButton
            // 
            this.arcticRadioButton.AutoSize = true;
            this.arcticRadioButton.Checked = true;
            this.arcticRadioButton.Location = new System.Drawing.Point(11, 136);
            this.arcticRadioButton.Name = "arcticRadioButton";
            this.arcticRadioButton.Size = new System.Drawing.Size(66, 22);
            this.arcticRadioButton.TabIndex = 35;
            this.arcticRadioButton.TabStop = true;
            this.arcticRadioButton.Text = "Arctic";
            this.arcticRadioButton.UseVisualStyleBackColor = true;
            this.arcticRadioButton.CheckedChanged += new System.EventHandler(this.arcticRadioButton_CheckedChanged);
            // 
            // foodForagedLabel
            // 
            this.foodForagedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foodForagedLabel.AutoSize = true;
            this.foodForagedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodForagedLabel.Location = new System.Drawing.Point(275, 501);
            this.foodForagedLabel.Name = "foodForagedLabel";
            this.foodForagedLabel.Size = new System.Drawing.Size(131, 20);
            this.foodForagedLabel.TabIndex = 34;
            this.foodForagedLabel.Text = "4 Lbs / 1 Day(s)";
            // 
            // movementLabel
            // 
            this.movementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.movementLabel.AutoSize = true;
            this.movementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementLabel.Location = new System.Drawing.Point(275, 452);
            this.movementLabel.Name = "movementLabel";
            this.movementLabel.Size = new System.Drawing.Size(149, 20);
            this.movementLabel.TabIndex = 33;
            this.movementLabel.Text = "4 miles / .33 hexes";
            // 
            // decerementMovementButton
            // 
            this.decerementMovementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decerementMovementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decerementMovementButton.Location = new System.Drawing.Point(57, 438);
            this.decerementMovementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decerementMovementButton.Name = "decerementMovementButton";
            this.decerementMovementButton.Size = new System.Drawing.Size(45, 45);
            this.decerementMovementButton.TabIndex = 32;
            this.decerementMovementButton.Text = "-";
            this.decerementMovementButton.UseVisualStyleBackColor = true;
            this.decerementMovementButton.Click += new System.EventHandler(this.decerementMovementButton_Click);
            // 
            // incerementMovementButton
            // 
            this.incerementMovementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incerementMovementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incerementMovementButton.Location = new System.Drawing.Point(6, 438);
            this.incerementMovementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incerementMovementButton.Name = "incerementMovementButton";
            this.incerementMovementButton.Size = new System.Drawing.Size(45, 45);
            this.incerementMovementButton.TabIndex = 31;
            this.incerementMovementButton.Text = "+";
            this.incerementMovementButton.UseVisualStyleBackColor = true;
            this.incerementMovementButton.Click += new System.EventHandler(this.incerementMovementButton_Click);
            // 
            // decerementFoodButton
            // 
            this.decerementFoodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decerementFoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decerementFoodButton.Location = new System.Drawing.Point(57, 487);
            this.decerementFoodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decerementFoodButton.Name = "decerementFoodButton";
            this.decerementFoodButton.Size = new System.Drawing.Size(45, 45);
            this.decerementFoodButton.TabIndex = 30;
            this.decerementFoodButton.Text = "-";
            this.decerementFoodButton.UseVisualStyleBackColor = true;
            this.decerementFoodButton.Click += new System.EventHandler(this.decerementFoodButton_Click);
            // 
            // incerementFoodButton
            // 
            this.incerementFoodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incerementFoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incerementFoodButton.Location = new System.Drawing.Point(6, 487);
            this.incerementFoodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incerementFoodButton.Name = "incerementFoodButton";
            this.incerementFoodButton.Size = new System.Drawing.Size(45, 45);
            this.incerementFoodButton.TabIndex = 29;
            this.incerementFoodButton.Text = "+";
            this.incerementFoodButton.UseVisualStyleBackColor = true;
            this.incerementFoodButton.Click += new System.EventHandler(this.incerementFoodButton_Click);
            // 
            // daysWithoutFoodLabel
            // 
            this.daysWithoutFoodLabel.AutoSize = true;
            this.daysWithoutFoodLabel.Location = new System.Drawing.Point(161, 86);
            this.daysWithoutFoodLabel.Name = "daysWithoutFoodLabel";
            this.daysWithoutFoodLabel.Size = new System.Drawing.Size(64, 18);
            this.daysWithoutFoodLabel.TabIndex = 28;
            this.daysWithoutFoodLabel.Text = "0 Day(s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "Days without Food:";
            // 
            // foodRemainingLabel
            // 
            this.foodRemainingLabel.AutoSize = true;
            this.foodRemainingLabel.Location = new System.Drawing.Point(161, 59);
            this.foodRemainingLabel.Name = "foodRemainingLabel";
            this.foodRemainingLabel.Size = new System.Drawing.Size(112, 18);
            this.foodRemainingLabel.TabIndex = 26;
            this.foodRemainingLabel.Text = "3 Lbs / 3 Day(s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Food Remaining:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Food Foraged:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(108, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Player Movement:";
            // 
            // rationLevelComboBox
            // 
            this.rationLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rationLevelComboBox.FormattingEnabled = true;
            this.rationLevelComboBox.Items.AddRange(new object[] {
            "Full Rations",
            "Half Rations"});
            this.rationLevelComboBox.Location = new System.Drawing.Point(6, 407);
            this.rationLevelComboBox.Name = "rationLevelComboBox";
            this.rationLevelComboBox.Size = new System.Drawing.Size(121, 26);
            this.rationLevelComboBox.TabIndex = 20;
            this.rationLevelComboBox.Text = "Full Rations";
            this.rationLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.rationLevelComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(878, 3);
            this.label12.TabIndex = 19;
            // 
            // endDayButton
            // 
            this.endDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endDayButton.Location = new System.Drawing.Point(6, 536);
            this.endDayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDayButton.Name = "endDayButton";
            this.endDayButton.Size = new System.Drawing.Size(121, 38);
            this.endDayButton.TabIndex = 11;
            this.endDayButton.Text = "End Day";
            this.endDayButton.UseVisualStyleBackColor = true;
            this.endDayButton.Click += new System.EventHandler(this.endDayButton_Click);
            // 
            // weatherEffectLabel
            // 
            this.weatherEffectLabel.AutoSize = true;
            this.weatherEffectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherEffectLabel.Location = new System.Drawing.Point(231, 30);
            this.weatherEffectLabel.Name = "weatherEffectLabel";
            this.weatherEffectLabel.Size = new System.Drawing.Size(654, 17);
            this.weatherEffectLabel.TabIndex = 4;
            this.weatherEffectLabel.Text = "Every hour not spent in warm shelter results in a DC 10 Con saving throw or gain " +
    "1 point of exhaustion.";
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.Location = new System.Drawing.Point(33, 30);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(58, 17);
            this.weatherLabel.TabIndex = 3;
            this.weatherLabel.Text = "Blizzard";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(878, 3);
            this.label10.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Weather Effects";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current Weather";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.diceRollButton);
            this.tabPage3.Controls.Add(this.label54);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.labe53);
            this.tabPage3.Controls.Add(this.diceResultLabel);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.modifierTextBox);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.diceSizeTextBox);
            this.tabPage3.Controls.Add(this.numberDiceTextBox);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(891, 584);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Dice Roller";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // diceRollButton
            // 
            this.diceRollButton.Location = new System.Drawing.Point(398, 28);
            this.diceRollButton.Name = "diceRollButton";
            this.diceRollButton.Size = new System.Drawing.Size(116, 45);
            this.diceRollButton.TabIndex = 10;
            this.diceRollButton.Text = "Roll Dice!";
            this.diceRollButton.UseVisualStyleBackColor = true;
            this.diceRollButton.Click += new System.EventHandler(this.diceRollButton_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(295, 76);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(69, 18);
            this.label54.TabIndex = 9;
            this.label54.Text = "Modifiers";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(167, 76);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(71, 18);
            this.label53.TabIndex = 8;
            this.label53.Text = "Dice Size";
            // 
            // labe53
            // 
            this.labe53.AutoSize = true;
            this.labe53.Location = new System.Drawing.Point(44, 76);
            this.labe53.Name = "labe53";
            this.labe53.Size = new System.Drawing.Size(50, 18);
            this.labe53.TabIndex = 7;
            this.labe53.Text = "# Dice";
            // 
            // diceResultLabel
            // 
            this.diceResultLabel.AutoSize = true;
            this.diceResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceResultLabel.Location = new System.Drawing.Point(202, 117);
            this.diceResultLabel.Name = "diceResultLabel";
            this.diceResultLabel.Size = new System.Drawing.Size(28, 38);
            this.diceResultLabel.TabIndex = 6;
            this.diceResultLabel.Text = "-";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(3, 117);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(185, 38);
            this.label51.TabIndex = 5;
            this.label51.Text = "You Rolled:";
            // 
            // modifierTextBox
            // 
            this.modifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierTextBox.Location = new System.Drawing.Point(287, 28);
            this.modifierTextBox.Name = "modifierTextBox";
            this.modifierTextBox.Size = new System.Drawing.Size(79, 45);
            this.modifierTextBox.TabIndex = 4;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(244, 28);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(36, 38);
            this.label50.TabIndex = 3;
            this.label50.Text = "+";
            // 
            // diceSizeTextBox
            // 
            this.diceSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSizeTextBox.Location = new System.Drawing.Point(159, 28);
            this.diceSizeTextBox.Name = "diceSizeTextBox";
            this.diceSizeTextBox.Size = new System.Drawing.Size(79, 45);
            this.diceSizeTextBox.TabIndex = 2;
            // 
            // numberDiceTextBox
            // 
            this.numberDiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDiceTextBox.Location = new System.Drawing.Point(32, 28);
            this.numberDiceTextBox.Name = "numberDiceTextBox";
            this.numberDiceTextBox.Size = new System.Drawing.Size(79, 45);
            this.numberDiceTextBox.TabIndex = 1;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(117, 28);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(35, 38);
            this.label49.TabIndex = 0;
            this.label49.Text = "d";
            // 
            // dmView
            // 
            this.dmView.Controls.Add(this.notesTextBox);
            this.dmView.Location = new System.Drawing.Point(4, 64);
            this.dmView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dmView.Name = "dmView";
            this.dmView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dmView.Size = new System.Drawing.Size(912, 671);
            this.dmView.TabIndex = 4;
            this.dmView.Text = "DM Notes";
            this.dmView.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Location = new System.Drawing.Point(7, 7);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(899, 615);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.Text = "";
            // 
            // HeightControlImageList
            // 
            this.HeightControlImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.HeightControlImageList.ImageSize = new System.Drawing.Size(1, 10);
            this.HeightControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationBar});
            this.statusStrip2.Location = new System.Drawing.Point(0, 752);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip2.Size = new System.Drawing.Size(944, 25);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // notificationBar
            // 
            this.notificationBar.Name = "notificationBar";
            this.notificationBar.Size = new System.Drawing.Size(118, 20);
            this.notificationBar.Text = "No Notifications";
            // 
            // setFoodTextBox
            // 
            this.setFoodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFoodTextBox.Location = new System.Drawing.Point(11, 192);
            this.setFoodTextBox.Name = "setFoodTextBox";
            this.setFoodTextBox.Size = new System.Drawing.Size(57, 30);
            this.setFoodTextBox.TabIndex = 39;
            // 
            // setFoodButton
            // 
            this.setFoodButton.Location = new System.Drawing.Point(74, 190);
            this.setFoodButton.Name = "setFoodButton";
            this.setFoodButton.Size = new System.Drawing.Size(88, 32);
            this.setFoodButton.TabIndex = 41;
            this.setFoodButton.Text = "Set Food";
            this.setFoodButton.UseVisualStyleBackColor = true;
            this.setFoodButton.Click += new System.EventHandler(this.setFoodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 777);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dungeon Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.TabControl.ResumeLayout(false);
            this.partyView.ResumeLayout(false);
            this.partyView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyListView)).EndInit();
            this.combatView.ResumeLayout(false);
            this.combatView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatListView)).EndInit();
            this.npcView.ResumeLayout(false);
            this.npcView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcListView)).EndInit();
            this.generatorView.ResumeLayout(false);
            this.generatorTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magicItemShopListView)).EndInit();
            this.miscView.ResumeLayout(false);
            this.miscTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.dmView.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.TabPage partyView;
        public System.Windows.Forms.TabPage combatView;
        public System.Windows.Forms.TabPage npcView;
        public System.Windows.Forms.TabPage generatorView;
        public System.Windows.Forms.TabPage dmView;
        public System.Windows.Forms.RichTextBox notesTextBox;
        public System.Windows.Forms.TabPage miscView;
        private System.Windows.Forms.ImageList HeightControlImageList;
        public BrightIdeasSoftware.ObjectListView npcListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.ObjectListView combatListView;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        internal BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.ObjectListView partyListView;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.Button removeCombatButton;
        private System.Windows.Forms.Button addCombatButton;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel notificationBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monsterHPTextBox;
        private System.Windows.Forms.TextBox monsterInitiativeTextBox;
        private System.Windows.Forms.TextBox monsterNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox partyHPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox partyPerceptionTextBox;
        private System.Windows.Forms.TextBox partyRaceTextBox;
        private System.Windows.Forms.TextBox partyNameTextBox;
        private System.Windows.Forms.Button removePartyButton;
        private System.Windows.Forms.Button addPartyButton;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private System.Windows.Forms.TabControl generatorTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.TabControl miscTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label weatherEffectLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Button endDayButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox rationLevelComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label daysWithoutFoodLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label foodRemainingLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label foodForagedLabel;
        private System.Windows.Forms.Label movementLabel;
        private System.Windows.Forms.Button decerementMovementButton;
        private System.Windows.Forms.Button incerementMovementButton;
        private System.Windows.Forms.Button decerementFoodButton;
        private System.Windows.Forms.Button incerementFoodButton;
        private System.Windows.Forms.RadioButton plainsRadioButton;
        private System.Windows.Forms.RadioButton arcticRadioButton;
        private System.Windows.Forms.Label biomeLabel;
        public System.Windows.Forms.RichTextBox survivalNotesTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.RichTextBox npcBiographyRichTextBox;
        private System.Windows.Forms.Button saveNPCButton;
        private System.Windows.Forms.Button rollLastNameButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button rollFirstNameButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox npcBioRichTextBox;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox npcLocationTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox npcRaceTextBox;
        private System.Windows.Forms.TextBox npcSexTextBox;
        private System.Windows.Forms.TextBox npcNameTextBox;
        private System.Windows.Forms.Button removeNPCButton;
        private System.Windows.Forms.Button addNPCButton;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox generatorLocationTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox partyACTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox monsterACTextBox;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
        private System.Windows.Forms.Button rollFullNameButton;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button rollSettlementNotableTraitButton;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox settlementTypeComboBox;
        private System.Windows.Forms.Label geographyNameLabel;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button geographyButton;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox geographyComboBox;
        private System.Windows.Forms.Button monsterDamageButton;
        private System.Windows.Forms.Button interactionButton;
        private System.Windows.Forms.Button mannerismButton;
        private System.Windows.Forms.Button appearanceButton;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button allTraitsButton;
        private System.Windows.Forms.Button talentButton;
        private System.Windows.Forms.Button flawButton;
        private System.Windows.Forms.Button createNPCButton;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label npcTalentLabel;
        private System.Windows.Forms.Label npcFlawLabel;
        private System.Windows.Forms.Label npcInteractionLabel;
        private System.Windows.Forms.Label npcMannerismLabel;
        private System.Windows.Forms.Label npcNameLabel;
        private System.Windows.Forms.Label npcSexLabel;
        private System.Windows.Forms.Label npcRaceLabel;
        private System.Windows.Forms.Label npcLocationLabel;
        private System.Windows.Forms.Label npcAppearanceLabel;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label labe53;
        private System.Windows.Forms.Label diceResultLabel;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox modifierTextBox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox diceSizeTextBox;
        private System.Windows.Forms.TextBox numberDiceTextBox;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button diceRollButton;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Button rollSettlementTraitsButton;
        private System.Windows.Forms.Button rollSettlementNameButton;
        private System.Windows.Forms.Button rollSettlementRulerStatusButton;
        private System.Windows.Forms.Button rollSettlementRelationsButton;
        private System.Windows.Forms.Button rollSettlementCalamityButton;
        private System.Windows.Forms.Button rollSettlementKnownForButton;
        private System.Windows.Forms.TextBox settlementCountryTextBox;
        private System.Windows.Forms.Button saveSettlementButton;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.RichTextBox settlementDescriptionRichTextBox;
        private System.Windows.Forms.TextBox settlementCurrentCalamityTextBox;
        private System.Windows.Forms.TextBox settlementKnownForTextBox;
        private System.Windows.Forms.TextBox settlementNotableTraitTextBox;
        private System.Windows.Forms.TextBox settlementRulerStatusTextBox;
        private System.Windows.Forms.TextBox settlementRaceRelationsTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox settlementNameTextBox;
        private System.Windows.Forms.Button rollSettlementButton;
        private System.Windows.Forms.TextBox settlementRaceTextBox;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox treasureTextBox;
        private System.Windows.Forms.Label treasureLabel;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button rollTreasureButton;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox firstNameLabel;
        private System.Windows.Forms.TextBox talentLabel;
        private System.Windows.Forms.TextBox flawLabel;
        private System.Windows.Forms.TextBox interactionLabel;
        private System.Windows.Forms.TextBox mannerismLabel;
        private System.Windows.Forms.TextBox appearanceLabel;
        private System.Windows.Forms.TextBox lastNameLabel;
        private System.Windows.Forms.TabPage tabPage7;
        private BrightIdeasSoftware.ObjectListView magicItemShopListView;
        private BrightIdeasSoftware.OLVColumn olvColumn20;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private System.Windows.Forms.Button generateShopButton;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox magicItemShopQualityComboBox;
        private BrightIdeasSoftware.OLVColumn olvColumn17;
        private System.Windows.Forms.TextBox monsterDamageTextBox;
        private System.Windows.Forms.Button loadCombatButton;
        private System.Windows.Forms.Button saveCombatButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox partySizeTextBox;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private System.Windows.Forms.TextBox combatDiceModifierTextBox;
        private System.Windows.Forms.TextBox combatDiceSizeTextBox;
        private System.Windows.Forms.TextBox combatNumberDiceTextBox;
        private System.Windows.Forms.Button combatRollDiceButton;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.CheckBox combatIsNPCCheckbox;
        private System.Windows.Forms.CheckBox partyIsNpcCheckbox;
        private System.Windows.Forms.Button setFoodButton;
        private System.Windows.Forms.TextBox setFoodTextBox;
    }
}
