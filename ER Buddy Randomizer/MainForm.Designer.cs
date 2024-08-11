namespace ER_Buddy_Randomizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            n_damageMult = new NumericUpDown();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            n_rngSeed = new NumericUpDown();
            label_randomseed = new Label();
            n_fpMin = new NumericUpDown();
            n_fpMax = new NumericUpDown();
            n_hpMult = new NumericUpDown();
            n_hpChance = new NumericUpDown();
            n_hpMax = new NumericUpDown();
            n_hpMin = new NumericUpDown();
            b_getSettings = new Button();
            b_settingsSet = new Button();
            b_newSeed = new Button();
            b_browse = new Button();
            b_randomize = new Button();
            b_restoreRegulation = new Button();
            cb_bigBuddy = new CheckBox();
            n_multipleDupeChance = new NumericUpDown();
            n_multipleMax = new NumericUpDown();
            n_multipleChanceBase = new NumericUpDown();
            n_multipleChanceAdditional = new NumericUpDown();
            n_variantReuseChance = new NumericUpDown();
            cb_buddyReuse = new CheckBox();
            label16 = new Label();
            max = new Label();
            label7 = new Label();
            tb_settings = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            t_console = new TextBox();
            label11 = new Label();
            label14 = new Label();
            label5 = new Label();
            label15 = new Label();
            label19 = new Label();
            menuStrip1 = new MenuStrip();
            menu_info = new ToolStripMenuItem();
            settingsPresetsToolStripMenuItem = new ToolStripMenuItem();
            preset_fun = new ToolStripMenuItem();
            preset_reasonable = new ToolStripMenuItem();
            preset_CHAOS = new ToolStripMenuItem();
            preset_family = new ToolStripMenuItem();
            preset_playground = new ToolStripMenuItem();
            balancedToolStripMenuItem = new ToolStripMenuItem();
            label17 = new Label();
            label20 = new Label();
            label1 = new Label();
            label2 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)n_damageMult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_rngSeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_fpMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_fpMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_hpChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleDupeChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleChanceBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleChanceAdditional).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_variantReuseChance).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "regulation.bin";
            openFileDialog1.Filter = "Regulation File|regulation.bin|All Files|*.*";
            openFileDialog1.Title = "Open \"regulation.bin\"";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(411, 72);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 11;
            label3.Text = "Damage Multiplier";
            // 
            // n_damageMult
            // 
            n_damageMult.Anchor = AnchorStyles.Right;
            n_damageMult.DecimalPlaces = 2;
            n_damageMult.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            n_damageMult.Location = new Point(422, 90);
            n_damageMult.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            n_damageMult.Minimum = new decimal(new int[] { 99, 0, 0, -2147352576 });
            n_damageMult.Name = "n_damageMult";
            n_damageMult.Size = new Size(62, 23);
            n_damageMult.TabIndex = 10;
            toolTip1.SetToolTip(n_damageMult, "Multiply's buddy damage.\r\nMultiplier is additive with multipliers gained during reinforcement.");
            n_damageMult.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(349, 36);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 12;
            label4.Text = "Buddy Stats";
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 40;
            // 
            // n_rngSeed
            // 
            n_rngSeed.Anchor = AnchorStyles.Top;
            n_rngSeed.Location = new Point(85, 394);
            n_rngSeed.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            n_rngSeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            n_rngSeed.Name = "n_rngSeed";
            n_rngSeed.Size = new Size(107, 23);
            n_rngSeed.TabIndex = 34;
            n_rngSeed.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(n_rngSeed, "Seed used for RNG calculations. If no value is chosen, a random seed will be generated.\r\nCopy along with Settings Preset for consistent randomization.\r\n");
            n_rngSeed.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            n_rngSeed.ValueChanged += n_rngSeed_ValueChanged;
            // 
            // label_randomseed
            // 
            label_randomseed.Anchor = AnchorStyles.Top;
            label_randomseed.AutoSize = true;
            label_randomseed.CausesValidation = false;
            label_randomseed.Enabled = false;
            label_randomseed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_randomseed.ForeColor = SystemColors.ControlDarkDark;
            label_randomseed.Location = new Point(85, 420);
            label_randomseed.Name = "label_randomseed";
            label_randomseed.Size = new Size(113, 15);
            label_randomseed.TabIndex = 35;
            label_randomseed.Text = "(-1 = Random Seed)";
            toolTip1.SetToolTip(label_randomseed, "Input a number for consistent randomizer. If no seed is provided, one will be generated randomly.");
            // 
            // n_fpMin
            // 
            n_fpMin.Anchor = AnchorStyles.Right;
            n_fpMin.Location = new Point(331, 182);
            n_fpMin.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            n_fpMin.Name = "n_fpMin";
            n_fpMin.Size = new Size(62, 23);
            n_fpMin.TabIndex = 19;
            toolTip1.SetToolTip(n_fpMin, "Minimum FP cost to use spirit ash");
            n_fpMin.Value = new decimal(new int[] { 30, 0, 0, 0 });
            n_fpMin.ValueChanged += n_fpMin_ValueChanged;
            // 
            // n_fpMax
            // 
            n_fpMax.Anchor = AnchorStyles.Right;
            n_fpMax.Location = new Point(422, 182);
            n_fpMax.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            n_fpMax.Name = "n_fpMax";
            n_fpMax.Size = new Size(62, 23);
            n_fpMax.TabIndex = 21;
            toolTip1.SetToolTip(n_fpMax, "Maximum FP cost to use spirit ash");
            n_fpMax.Value = new decimal(new int[] { 60, 0, 0, 0 });
            n_fpMax.ValueChanged += n_fpMax_ValueChanged;
            // 
            // n_hpMult
            // 
            n_hpMult.Anchor = AnchorStyles.Right;
            n_hpMult.DecimalPlaces = 2;
            n_hpMult.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            n_hpMult.Location = new Point(331, 90);
            n_hpMult.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            n_hpMult.Minimum = new decimal(new int[] { 99, 0, 0, -2147352576 });
            n_hpMult.Name = "n_hpMult";
            n_hpMult.Size = new Size(62, 23);
            n_hpMult.TabIndex = 26;
            toolTip1.SetToolTip(n_hpMult, "Multiply's buddy Maximum HP.\r\nMultiplier is additive with multipliers gained during reinforcement.\r\n");
            n_hpMult.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // n_hpChance
            // 
            n_hpChance.Anchor = AnchorStyles.Right;
            n_hpChance.Location = new Point(331, 226);
            n_hpChance.Name = "n_hpChance";
            n_hpChance.Size = new Size(62, 23);
            n_hpChance.TabIndex = 44;
            toolTip1.SetToolTip(n_hpChance, "Chance for a spirit ash to cost HP instead of FP (100 = 100%)");
            n_hpChance.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // n_hpMax
            // 
            n_hpMax.Anchor = AnchorStyles.Right;
            n_hpMax.Location = new Point(422, 270);
            n_hpMax.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            n_hpMax.Name = "n_hpMax";
            n_hpMax.Size = new Size(62, 23);
            n_hpMax.TabIndex = 41;
            toolTip1.SetToolTip(n_hpMax, "Maximum HP cost to use spirit ash");
            n_hpMax.Value = new decimal(new int[] { 600, 0, 0, 0 });
            n_hpMax.ValueChanged += n_hpMax_ValueChanged;
            // 
            // n_hpMin
            // 
            n_hpMin.Anchor = AnchorStyles.Right;
            n_hpMin.Location = new Point(331, 270);
            n_hpMin.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            n_hpMin.Name = "n_hpMin";
            n_hpMin.Size = new Size(62, 23);
            n_hpMin.TabIndex = 39;
            toolTip1.SetToolTip(n_hpMin, "Minimum HP cost to use spirit ash");
            n_hpMin.Value = new decimal(new int[] { 300, 0, 0, 0 });
            n_hpMin.ValueChanged += n_hpMin_ValueChanged;
            // 
            // b_getSettings
            // 
            b_getSettings.Anchor = AnchorStyles.Top;
            b_getSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_getSettings.Location = new Point(33, 343);
            b_getSettings.Name = "b_getSettings";
            b_getSettings.Size = new Size(34, 23);
            b_getSettings.TabIndex = 58;
            b_getSettings.Text = "Get";
            toolTip1.SetToolTip(b_getSettings, "Generate new Settings Preset from current Randomizer settings");
            b_getSettings.UseVisualStyleBackColor = true;
            b_getSettings.Click += b_getSettings_Click;
            // 
            // b_settingsSet
            // 
            b_settingsSet.Anchor = AnchorStyles.Top;
            b_settingsSet.Enabled = false;
            b_settingsSet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_settingsSet.Location = new Point(198, 343);
            b_settingsSet.Name = "b_settingsSet";
            b_settingsSet.Size = new Size(34, 23);
            b_settingsSet.TabIndex = 59;
            b_settingsSet.Text = "Set";
            toolTip1.SetToolTip(b_settingsSet, "Change Randomizer settings to Settings Preset");
            b_settingsSet.UseVisualStyleBackColor = true;
            b_settingsSet.Click += b_settingsSet_Click;
            // 
            // b_newSeed
            // 
            b_newSeed.Anchor = AnchorStyles.Top;
            b_newSeed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_newSeed.Location = new Point(33, 394);
            b_newSeed.Name = "b_newSeed";
            b_newSeed.Size = new Size(45, 23);
            b_newSeed.TabIndex = 37;
            b_newSeed.Text = "New";
            toolTip1.SetToolTip(b_newSeed, "Generate new RNG seed");
            b_newSeed.UseVisualStyleBackColor = true;
            b_newSeed.Click += b_newSeed_Click;
            // 
            // b_browse
            // 
            b_browse.Anchor = AnchorStyles.Top;
            b_browse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_browse.Location = new Point(371, 466);
            b_browse.Name = "b_browse";
            b_browse.Size = new Size(74, 24);
            b_browse.TabIndex = 60;
            b_browse.Text = "Browse";
            toolTip1.SetToolTip(b_browse, "Browse and load ER's Regulation.bin file");
            b_browse.UseVisualStyleBackColor = true;
            b_browse.Click += b_browse_Click;
            // 
            // b_randomize
            // 
            b_randomize.Anchor = AnchorStyles.Top;
            b_randomize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_randomize.Location = new Point(451, 466);
            b_randomize.Name = "b_randomize";
            b_randomize.Size = new Size(74, 24);
            b_randomize.TabIndex = 61;
            b_randomize.Text = "Randomize";
            toolTip1.SetToolTip(b_randomize, "Initiate Randomizer");
            b_randomize.UseVisualStyleBackColor = true;
            b_randomize.Click += b_randomize_Click;
            // 
            // b_restoreRegulation
            // 
            b_restoreRegulation.Anchor = AnchorStyles.Top;
            b_restoreRegulation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_restoreRegulation.Location = new Point(12, 466);
            b_restoreRegulation.Name = "b_restoreRegulation";
            b_restoreRegulation.Size = new Size(103, 24);
            b_restoreRegulation.TabIndex = 62;
            b_restoreRegulation.Text = "Restore Backup";
            toolTip1.SetToolTip(b_restoreRegulation, "Restore Regulation.bin Backup");
            b_restoreRegulation.UseVisualStyleBackColor = true;
            b_restoreRegulation.Click += b_restoreRegulation_Click;
            // 
            // cb_bigBuddy
            // 
            cb_bigBuddy.Anchor = AnchorStyles.Top;
            cb_bigBuddy.AutoSize = true;
            cb_bigBuddy.Checked = true;
            cb_bigBuddy.CheckState = CheckState.Checked;
            cb_bigBuddy.Location = new Point(53, 255);
            cb_bigBuddy.Name = "cb_bigBuddy";
            cb_bigBuddy.Size = new Size(170, 19);
            cb_bigBuddy.TabIndex = 63;
            cb_bigBuddy.Text = "Forbid Large Multi-Buddies";
            toolTip1.SetToolTip(cb_bigBuddy, "Determines if large enemies can't be a Multi-Buddy");
            cb_bigBuddy.UseVisualStyleBackColor = true;
            // 
            // n_multipleDupeChance
            // 
            n_multipleDupeChance.Anchor = AnchorStyles.Top;
            n_multipleDupeChance.Location = new Point(164, 226);
            n_multipleDupeChance.Name = "n_multipleDupeChance";
            n_multipleDupeChance.Size = new Size(50, 23);
            n_multipleDupeChance.TabIndex = 15;
            toolTip1.SetToolTip(n_multipleDupeChance, "Chance for the 2nd+ Multi-Buddies to be the same enemy type as the 1st (100 = 100%)");
            n_multipleDupeChance.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // n_multipleMax
            // 
            n_multipleMax.Anchor = AnchorStyles.Top;
            n_multipleMax.Location = new Point(165, 182);
            n_multipleMax.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            n_multipleMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            n_multipleMax.Name = "n_multipleMax";
            n_multipleMax.Size = new Size(50, 23);
            n_multipleMax.TabIndex = 3;
            toolTip1.SetToolTip(n_multipleMax, "Maximum number of buddies a summon can generate, up to 10 summons at once.\r\nWarning: high values may cause issues.");
            n_multipleMax.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // n_multipleChanceBase
            // 
            n_multipleChanceBase.Anchor = AnchorStyles.Top;
            n_multipleChanceBase.Location = new Point(54, 182);
            n_multipleChanceBase.Name = "n_multipleChanceBase";
            n_multipleChanceBase.Size = new Size(50, 23);
            n_multipleChanceBase.TabIndex = 6;
            toolTip1.SetToolTip(n_multipleChanceBase, "Chance for a summon to generate more than 1 buddy (100 = 100%)\r\n");
            n_multipleChanceBase.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // n_multipleChanceAdditional
            // 
            n_multipleChanceAdditional.Anchor = AnchorStyles.Top;
            n_multipleChanceAdditional.Location = new Point(53, 226);
            n_multipleChanceAdditional.Name = "n_multipleChanceAdditional";
            n_multipleChanceAdditional.Size = new Size(50, 23);
            n_multipleChanceAdditional.TabIndex = 17;
            toolTip1.SetToolTip(n_multipleChanceAdditional, "Chance for a summon with 2+ buddies to generate a 3rd, 4th, 5th, etc. buddy (100 = 100%)\r\nAdditional Chance is checked for every additional buddy, until it fails or the Multi-Buddy Max is reached.");
            n_multipleChanceAdditional.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // n_variantReuseChance
            // 
            n_variantReuseChance.Anchor = AnchorStyles.Top;
            n_variantReuseChance.Location = new Point(53, 90);
            n_variantReuseChance.Name = "n_variantReuseChance";
            n_variantReuseChance.Size = new Size(50, 23);
            n_variantReuseChance.TabIndex = 47;
            toolTip1.SetToolTip(n_variantReuseChance, "Chance to permit choosing an enemy variant of a buddy that has already been chosen (100 = 100%)\r\nEnemy variant example: a small dog that inflicts rot is a small dog variant.\r\n");
            n_variantReuseChance.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // cb_buddyReuse
            // 
            cb_buddyReuse.Anchor = AnchorStyles.Top;
            cb_buddyReuse.AutoSize = true;
            cb_buddyReuse.Location = new Point(149, 94);
            cb_buddyReuse.Name = "cb_buddyReuse";
            cb_buddyReuse.Size = new Size(127, 19);
            cb_buddyReuse.TabIndex = 50;
            cb_buddyReuse.Text = "Allow Buddy Reuse";
            toolTip1.SetToolTip(cb_buddyReuse, "Determines if a buddy that has already been selected can be chosen again.\r\nDoes not affect Multi-buddy dupe chance (which only affects multi-buddies)");
            cb_buddyReuse.UseVisualStyleBackColor = true;
            cb_buddyReuse.CheckedChanged += cb_buddyReuse_CheckedChanged;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(322, 208);
            label16.Name = "label16";
            label16.Size = new Size(93, 15);
            label16.TabIndex = 45;
            label16.Text = "HP Cost Chance";
            // 
            // max
            // 
            max.Anchor = AnchorStyles.Top;
            max.AutoSize = true;
            max.Location = new Point(149, 165);
            max.Name = "max";
            max.Size = new Size(100, 15);
            max.TabIndex = 5;
            max.Text = "Multi-Buddy Max";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(151, 208);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 16;
            label7.Text = "Dupe Chance";
            // 
            // tb_settings
            // 
            tb_settings.Anchor = AnchorStyles.Top;
            tb_settings.Location = new Point(74, 343);
            tb_settings.Name = "tb_settings";
            tb_settings.PlaceholderText = "No Preset";
            tb_settings.Size = new Size(118, 23);
            tb_settings.TabIndex = 57;
            tb_settings.TextAlign = HorizontalAlignment.Center;
            tb_settings.TextChanged += tb_settings_TextChanged;
            tb_settings.MouseEnter += tb_settings_ManualToolTip;
            tb_settings.MouseLeave += tb_settings_MouseLeave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 131);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 14;
            label6.Text = "Multi-Summons";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(322, 164);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 20;
            label8.Text = "FP Cost Min";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(411, 164);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 22;
            label9.Text = "FP Cost Max";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(361, 131);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 23;
            label10.Text = "Ash Stats";
            // 
            // t_console
            // 
            t_console.Anchor = AnchorStyles.Bottom;
            t_console.Location = new Point(121, 466);
            t_console.Name = "t_console";
            t_console.ReadOnly = true;
            t_console.Size = new Size(244, 23);
            t_console.TabIndex = 24;
            t_console.Text = "Waiting for regulation";
            t_console.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(74, 292);
            label11.Name = "label11";
            label11.Size = new Size(118, 25);
            label11.TabIndex = 25;
            label11.Text = "RNG Control";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(322, 72);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 36;
            label14.Text = "HP Multiplier";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(411, 252);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 42;
            label5.Text = "HP Cost Max";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(322, 252);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 40;
            label15.Text = "HP Cost Min";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(60, 36);
            label19.Name = "label19";
            label19.Size = new Size(147, 25);
            label19.TabIndex = 49;
            label19.Text = "Initial Summons";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_info, settingsPresetsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(537, 24);
            menuStrip1.TabIndex = 51;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_info
            // 
            menu_info.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu_info.Name = "menu_info";
            menu_info.RightToLeft = RightToLeft.Yes;
            menu_info.Size = new Size(40, 20);
            menu_info.Text = "Info";
            menu_info.Click += menu_info_Click;
            // 
            // settingsPresetsToolStripMenuItem
            // 
            settingsPresetsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preset_fun, preset_reasonable, preset_CHAOS, preset_family, preset_playground, balancedToolStripMenuItem });
            settingsPresetsToolStripMenuItem.Name = "settingsPresetsToolStripMenuItem";
            settingsPresetsToolStripMenuItem.Size = new Size(101, 20);
            settingsPresetsToolStripMenuItem.Text = "Settings Presets";
            // 
            // preset_fun
            // 
            preset_fun.Name = "preset_fun";
            preset_fun.Size = new Size(135, 22);
            preset_fun.Text = "Fun";
            preset_fun.Click += preset_fun_Click;
            // 
            // preset_reasonable
            // 
            preset_reasonable.Name = "preset_reasonable";
            preset_reasonable.Size = new Size(135, 22);
            preset_reasonable.Text = "Reasonable";
            preset_reasonable.Click += preset_reasonable_Click;
            // 
            // preset_CHAOS
            // 
            preset_CHAOS.Name = "preset_CHAOS";
            preset_CHAOS.Size = new Size(135, 22);
            preset_CHAOS.Text = "CHAOS";
            preset_CHAOS.Click += preset_CHAOS_Click;
            // 
            // preset_family
            // 
            preset_family.Name = "preset_family";
            preset_family.Size = new Size(135, 22);
            preset_family.Text = "Family";
            preset_family.Click += preset_family_Click;
            // 
            // preset_playground
            // 
            preset_playground.Name = "preset_playground";
            preset_playground.Size = new Size(135, 22);
            preset_playground.Text = "Playground";
            preset_playground.Click += preset_playground_Click;
            // 
            // balancedToolStripMenuItem
            // 
            balancedToolStripMenuItem.Name = "balancedToolStripMenuItem";
            balancedToolStripMenuItem.Size = new Size(135, 22);
            balancedToolStripMenuItem.Text = "\"Balanced\"";
            balancedToolStripMenuItem.Click += balancedToolStripMenuItem_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(99, 376);
            label17.Name = "label17";
            label17.Size = new Size(59, 15);
            label17.TabIndex = 52;
            label17.Text = "RNG Seed";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(85, 325);
            label20.Name = "label20";
            label20.Size = new Size(84, 15);
            label20.TabIndex = 56;
            label20.Text = "Settings Preset";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(37, 165);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Initial Chance";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(37, 208);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 18;
            label2.Text = "Additional Chance";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Location = new Point(37, 72);
            label18.Name = "label18";
            label18.Size = new Size(119, 15);
            label18.TabIndex = 48;
            label18.Text = "Allow Variant Chance";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 502);
            Controls.Add(cb_bigBuddy);
            Controls.Add(b_restoreRegulation);
            Controls.Add(b_randomize);
            Controls.Add(b_browse);
            Controls.Add(b_settingsSet);
            Controls.Add(b_getSettings);
            Controls.Add(tb_settings);
            Controls.Add(label20);
            Controls.Add(label17);
            Controls.Add(cb_buddyReuse);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(n_variantReuseChance);
            Controls.Add(label16);
            Controls.Add(n_hpChance);
            Controls.Add(label5);
            Controls.Add(n_hpMax);
            Controls.Add(label15);
            Controls.Add(n_hpMin);
            Controls.Add(b_newSeed);
            Controls.Add(label14);
            Controls.Add(label_randomseed);
            Controls.Add(n_rngSeed);
            Controls.Add(n_hpMult);
            Controls.Add(label11);
            Controls.Add(t_console);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(n_fpMax);
            Controls.Add(label8);
            Controls.Add(n_fpMin);
            Controls.Add(label2);
            Controls.Add(n_multipleChanceAdditional);
            Controls.Add(label7);
            Controls.Add(n_multipleDupeChance);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(n_damageMult);
            Controls.Add(label1);
            Controls.Add(n_multipleChanceBase);
            Controls.Add(max);
            Controls.Add(n_multipleMax);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Elden Ring Summon Randomizer";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)n_damageMult).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_rngSeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_fpMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_fpMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMult).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_hpChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_hpMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleDupeChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleChanceBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_multipleChanceAdditional).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_variantReuseChance).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private NumericUpDown n_damageMult;
        private Label label4;
        private ToolTip toolTip1;
        private Label label6;
        private Label label8;
        private NumericUpDown n_fpMin;
        private NumericUpDown n_fpMax;
        private Label label9;
        private Label label10;
        private TextBox t_console;
        private Label label11;
        private NumericUpDown n_hpMult;
        private NumericUpDown n_rngSeed;
        private Label label_randomseed;
        private Label label14;
        private Button b_newSeed;
        private Label label5;
        private NumericUpDown n_hpMax;
        private Label label15;
        private NumericUpDown n_hpMin;
        private Label label16;
        private NumericUpDown n_hpChance;
        private Label label19;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_info;
        private Label label17;
        private Label label20;
        private TextBox tb_settings;
        private Button b_getSettings;
        private Button b_settingsSet;
        private Button b_browse;
        private Button b_randomize;
        private Button b_restoreRegulation;
        private ToolStripMenuItem settingsPresetsToolStripMenuItem;
        private ToolStripMenuItem preset_fun;
        private ToolStripMenuItem preset_reasonable;
        private ToolStripMenuItem preset_CHAOS;
        private ToolStripMenuItem preset_family;
        private ToolStripMenuItem playgroundToolStripMenuItem;
        private ToolStripMenuItem preset_playground;
        private CheckBox cb_bigBuddy;
        private NumericUpDown n_multipleDupeChance;
        private Label label1;
        private NumericUpDown n_multipleMax;
        private Label max;
        private NumericUpDown n_multipleChanceBase;
        private Label label7;
        private NumericUpDown n_multipleChanceAdditional;
        private Label label2;
        private NumericUpDown n_variantReuseChance;
        private Label label18;
        private CheckBox cb_buddyReuse;
        private ToolStripMenuItem balancedToolStripMenuItem;
    }
}