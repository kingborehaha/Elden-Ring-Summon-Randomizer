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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.n_damageMult = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.n_rngSeed = new System.Windows.Forms.NumericUpDown();
            this.label_randomseed = new System.Windows.Forms.Label();
            this.n_fpMin = new System.Windows.Forms.NumericUpDown();
            this.n_fpMax = new System.Windows.Forms.NumericUpDown();
            this.n_hpMult = new System.Windows.Forms.NumericUpDown();
            this.n_hpChance = new System.Windows.Forms.NumericUpDown();
            this.n_hpMax = new System.Windows.Forms.NumericUpDown();
            this.n_hpMin = new System.Windows.Forms.NumericUpDown();
            this.b_getSettings = new System.Windows.Forms.Button();
            this.b_settingsSet = new System.Windows.Forms.Button();
            this.b_newSeed = new System.Windows.Forms.Button();
            this.b_browse = new System.Windows.Forms.Button();
            this.b_randomize = new System.Windows.Forms.Button();
            this.b_restoreRegulation = new System.Windows.Forms.Button();
            this.cb_bigBuddy = new System.Windows.Forms.CheckBox();
            this.n_multipleDupeChance = new System.Windows.Forms.NumericUpDown();
            this.n_multipleMax = new System.Windows.Forms.NumericUpDown();
            this.n_multipleChanceBase = new System.Windows.Forms.NumericUpDown();
            this.n_multipleChanceAdditional = new System.Windows.Forms.NumericUpDown();
            this.n_variantReuseChance = new System.Windows.Forms.NumericUpDown();
            this.cb_buddyReuse = new System.Windows.Forms.CheckBox();
            this.cb_TeamAttack = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_settings = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_console = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_info = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset_fun = new System.Windows.Forms.ToolStripMenuItem();
            this.preset_reasonable = new System.Windows.Forms.ToolStripMenuItem();
            this.preset_CHAOS = new System.Windows.Forms.ToolStripMenuItem();
            this.preset_family = new System.Windows.Forms.ToolStripMenuItem();
            this.preset_playground = new System.Windows.Forms.ToolStripMenuItem();
            this.balancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_FollowBehavior = new System.Windows.Forms.ComboBox();
            this.combo_LargeFollowBehavior = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_damageMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_rngSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_fpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_fpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleDupeChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleChanceBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleChanceAdditional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_variantReuseChance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "regulation.bin";
            this.openFileDialog1.Filter = "Regulation File|regulation.bin|All Files|*.*";
            this.openFileDialog1.Title = "Open \"regulation.bin\"";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Damage Multiplier";
            // 
            // n_damageMult
            // 
            this.n_damageMult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_damageMult.DecimalPlaces = 2;
            this.n_damageMult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.n_damageMult.Location = new System.Drawing.Point(422, 90);
            this.n_damageMult.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n_damageMult.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147352576});
            this.n_damageMult.Name = "n_damageMult";
            this.n_damageMult.Size = new System.Drawing.Size(62, 23);
            this.n_damageMult.TabIndex = 10;
            this.toolTip1.SetToolTip(this.n_damageMult, "Multiply\'s buddy damage.\r\nMultiplier is additive with multipliers gained during r" +
        "einforcement.");
            this.n_damageMult.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(349, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buddy Stats";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // n_rngSeed
            // 
            this.n_rngSeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_rngSeed.Location = new System.Drawing.Point(360, 408);
            this.n_rngSeed.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.n_rngSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.n_rngSeed.Name = "n_rngSeed";
            this.n_rngSeed.Size = new System.Drawing.Size(107, 23);
            this.n_rngSeed.TabIndex = 34;
            this.n_rngSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.n_rngSeed, "Seed used for RNG calculations. If no value is chosen, a random seed will be gene" +
        "rated.\r\nCopy along with Settings Preset for consistent randomization.\r\n");
            this.n_rngSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.n_rngSeed.ValueChanged += new System.EventHandler(this.n_rngSeed_ValueChanged);
            // 
            // label_randomseed
            // 
            this.label_randomseed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_randomseed.AutoSize = true;
            this.label_randomseed.CausesValidation = false;
            this.label_randomseed.Enabled = false;
            this.label_randomseed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_randomseed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_randomseed.Location = new System.Drawing.Point(360, 434);
            this.label_randomseed.Name = "label_randomseed";
            this.label_randomseed.Size = new System.Drawing.Size(113, 15);
            this.label_randomseed.TabIndex = 35;
            this.label_randomseed.Text = "(-1 = Random Seed)";
            this.toolTip1.SetToolTip(this.label_randomseed, "Input a number for consistent randomizer. If no seed is provided, one will be gen" +
        "erated randomly.");
            // 
            // n_fpMin
            // 
            this.n_fpMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_fpMin.Location = new System.Drawing.Point(331, 182);
            this.n_fpMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.n_fpMin.Name = "n_fpMin";
            this.n_fpMin.Size = new System.Drawing.Size(62, 23);
            this.n_fpMin.TabIndex = 19;
            this.toolTip1.SetToolTip(this.n_fpMin, "Minimum FP cost to use spirit ash");
            this.n_fpMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.n_fpMin.ValueChanged += new System.EventHandler(this.n_fpMin_ValueChanged);
            // 
            // n_fpMax
            // 
            this.n_fpMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_fpMax.Location = new System.Drawing.Point(422, 182);
            this.n_fpMax.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.n_fpMax.Name = "n_fpMax";
            this.n_fpMax.Size = new System.Drawing.Size(62, 23);
            this.n_fpMax.TabIndex = 21;
            this.toolTip1.SetToolTip(this.n_fpMax, "Maximum FP cost to use spirit ash");
            this.n_fpMax.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.n_fpMax.ValueChanged += new System.EventHandler(this.n_fpMax_ValueChanged);
            // 
            // n_hpMult
            // 
            this.n_hpMult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_hpMult.DecimalPlaces = 2;
            this.n_hpMult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.n_hpMult.Location = new System.Drawing.Point(331, 90);
            this.n_hpMult.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n_hpMult.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147352576});
            this.n_hpMult.Name = "n_hpMult";
            this.n_hpMult.Size = new System.Drawing.Size(62, 23);
            this.n_hpMult.TabIndex = 26;
            this.toolTip1.SetToolTip(this.n_hpMult, "Multiply\'s buddy Maximum HP.\r\nMultiplier is additive with multipliers gained duri" +
        "ng reinforcement.\r\n");
            this.n_hpMult.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // n_hpChance
            // 
            this.n_hpChance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_hpChance.Location = new System.Drawing.Point(331, 226);
            this.n_hpChance.Name = "n_hpChance";
            this.n_hpChance.Size = new System.Drawing.Size(62, 23);
            this.n_hpChance.TabIndex = 44;
            this.toolTip1.SetToolTip(this.n_hpChance, "Chance for a spirit ash to cost HP instead of FP (100 = 100%)");
            this.n_hpChance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // n_hpMax
            // 
            this.n_hpMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_hpMax.Location = new System.Drawing.Point(422, 270);
            this.n_hpMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.n_hpMax.Name = "n_hpMax";
            this.n_hpMax.Size = new System.Drawing.Size(62, 23);
            this.n_hpMax.TabIndex = 41;
            this.toolTip1.SetToolTip(this.n_hpMax, "Maximum HP cost to use spirit ash");
            this.n_hpMax.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.n_hpMax.ValueChanged += new System.EventHandler(this.n_hpMax_ValueChanged);
            // 
            // n_hpMin
            // 
            this.n_hpMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_hpMin.Location = new System.Drawing.Point(331, 270);
            this.n_hpMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.n_hpMin.Name = "n_hpMin";
            this.n_hpMin.Size = new System.Drawing.Size(62, 23);
            this.n_hpMin.TabIndex = 39;
            this.toolTip1.SetToolTip(this.n_hpMin, "Minimum HP cost to use spirit ash");
            this.n_hpMin.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.n_hpMin.ValueChanged += new System.EventHandler(this.n_hpMin_ValueChanged);
            // 
            // b_getSettings
            // 
            this.b_getSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_getSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_getSettings.Location = new System.Drawing.Point(308, 357);
            this.b_getSettings.Name = "b_getSettings";
            this.b_getSettings.Size = new System.Drawing.Size(34, 23);
            this.b_getSettings.TabIndex = 58;
            this.b_getSettings.Text = "Get";
            this.toolTip1.SetToolTip(this.b_getSettings, "Generate new Settings Preset from current Randomizer settings");
            this.b_getSettings.UseVisualStyleBackColor = true;
            this.b_getSettings.Click += new System.EventHandler(this.b_getSettings_Click);
            // 
            // b_settingsSet
            // 
            this.b_settingsSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_settingsSet.Enabled = false;
            this.b_settingsSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_settingsSet.Location = new System.Drawing.Point(473, 357);
            this.b_settingsSet.Name = "b_settingsSet";
            this.b_settingsSet.Size = new System.Drawing.Size(34, 23);
            this.b_settingsSet.TabIndex = 59;
            this.b_settingsSet.Text = "Set";
            this.toolTip1.SetToolTip(this.b_settingsSet, "Change Randomizer settings to Settings Preset");
            this.b_settingsSet.UseVisualStyleBackColor = true;
            this.b_settingsSet.Click += new System.EventHandler(this.b_settingsSet_Click);
            // 
            // b_newSeed
            // 
            this.b_newSeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_newSeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_newSeed.Location = new System.Drawing.Point(308, 408);
            this.b_newSeed.Name = "b_newSeed";
            this.b_newSeed.Size = new System.Drawing.Size(45, 23);
            this.b_newSeed.TabIndex = 37;
            this.b_newSeed.Text = "New";
            this.toolTip1.SetToolTip(this.b_newSeed, "Generate new RNG seed");
            this.b_newSeed.UseVisualStyleBackColor = true;
            this.b_newSeed.Click += new System.EventHandler(this.b_newSeed_Click);
            // 
            // b_browse
            // 
            this.b_browse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_browse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_browse.Location = new System.Drawing.Point(371, 467);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(74, 24);
            this.b_browse.TabIndex = 60;
            this.b_browse.Text = "Browse";
            this.toolTip1.SetToolTip(this.b_browse, "Browse and load ER\'s Regulation.bin file");
            this.b_browse.UseVisualStyleBackColor = true;
            this.b_browse.Click += new System.EventHandler(this.b_browse_Click);
            // 
            // b_randomize
            // 
            this.b_randomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_randomize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_randomize.Location = new System.Drawing.Point(451, 467);
            this.b_randomize.Name = "b_randomize";
            this.b_randomize.Size = new System.Drawing.Size(74, 24);
            this.b_randomize.TabIndex = 61;
            this.b_randomize.Text = "Randomize";
            this.toolTip1.SetToolTip(this.b_randomize, "Initiate Randomizer");
            this.b_randomize.UseVisualStyleBackColor = true;
            this.b_randomize.Click += new System.EventHandler(this.b_randomize_Click);
            // 
            // b_restoreRegulation
            // 
            this.b_restoreRegulation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_restoreRegulation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_restoreRegulation.Location = new System.Drawing.Point(12, 467);
            this.b_restoreRegulation.Name = "b_restoreRegulation";
            this.b_restoreRegulation.Size = new System.Drawing.Size(103, 24);
            this.b_restoreRegulation.TabIndex = 62;
            this.b_restoreRegulation.Text = "Restore Backup";
            this.toolTip1.SetToolTip(this.b_restoreRegulation, "Restore Regulation.bin Backup");
            this.b_restoreRegulation.UseVisualStyleBackColor = true;
            this.b_restoreRegulation.Click += new System.EventHandler(this.b_restoreRegulation_Click);
            // 
            // cb_bigBuddy
            // 
            this.cb_bigBuddy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bigBuddy.AutoSize = true;
            this.cb_bigBuddy.Checked = true;
            this.cb_bigBuddy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_bigBuddy.Location = new System.Drawing.Point(53, 255);
            this.cb_bigBuddy.Name = "cb_bigBuddy";
            this.cb_bigBuddy.Size = new System.Drawing.Size(170, 19);
            this.cb_bigBuddy.TabIndex = 63;
            this.cb_bigBuddy.Text = "Forbid Large Multi-Buddies";
            this.toolTip1.SetToolTip(this.cb_bigBuddy, "Determines if large enemies can\'t be a Multi-Buddy");
            this.cb_bigBuddy.UseVisualStyleBackColor = true;
            // 
            // n_multipleDupeChance
            // 
            this.n_multipleDupeChance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_multipleDupeChance.Location = new System.Drawing.Point(164, 226);
            this.n_multipleDupeChance.Name = "n_multipleDupeChance";
            this.n_multipleDupeChance.Size = new System.Drawing.Size(50, 23);
            this.n_multipleDupeChance.TabIndex = 15;
            this.toolTip1.SetToolTip(this.n_multipleDupeChance, "Chance for the 2nd+ Multi-Buddies to be the same enemy type as the 1st (100 = 100" +
        "%)");
            this.n_multipleDupeChance.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // n_multipleMax
            // 
            this.n_multipleMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_multipleMax.Location = new System.Drawing.Point(165, 182);
            this.n_multipleMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_multipleMax.Name = "n_multipleMax";
            this.n_multipleMax.Size = new System.Drawing.Size(50, 23);
            this.n_multipleMax.TabIndex = 3;
            this.toolTip1.SetToolTip(this.n_multipleMax, "Maximum number of buddies a summon can generate.\r\nWarning: High values will cause" +
        " issues, and very high values will cause very nasty issues!");
            this.n_multipleMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // n_multipleChanceBase
            // 
            this.n_multipleChanceBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_multipleChanceBase.Location = new System.Drawing.Point(54, 182);
            this.n_multipleChanceBase.Name = "n_multipleChanceBase";
            this.n_multipleChanceBase.Size = new System.Drawing.Size(50, 23);
            this.n_multipleChanceBase.TabIndex = 6;
            this.toolTip1.SetToolTip(this.n_multipleChanceBase, "Chance for a summon to generate more than 1 buddy (100 = 100%)\r\n");
            this.n_multipleChanceBase.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // n_multipleChanceAdditional
            // 
            this.n_multipleChanceAdditional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_multipleChanceAdditional.Location = new System.Drawing.Point(53, 226);
            this.n_multipleChanceAdditional.Name = "n_multipleChanceAdditional";
            this.n_multipleChanceAdditional.Size = new System.Drawing.Size(50, 23);
            this.n_multipleChanceAdditional.TabIndex = 17;
            this.toolTip1.SetToolTip(this.n_multipleChanceAdditional, "Chance for a summon with 2+ buddies to generate a 3rd, 4th, 5th, etc. buddy (100 " +
        "= 100%)\r\nAdditional Chance is checked for every additional buddy, until it fails" +
        " or the Multi-Buddy Max is reached.");
            this.n_multipleChanceAdditional.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // n_variantReuseChance
            // 
            this.n_variantReuseChance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n_variantReuseChance.Location = new System.Drawing.Point(53, 90);
            this.n_variantReuseChance.Name = "n_variantReuseChance";
            this.n_variantReuseChance.Size = new System.Drawing.Size(50, 23);
            this.n_variantReuseChance.TabIndex = 47;
            this.toolTip1.SetToolTip(this.n_variantReuseChance, "Chance to permit choosing an enemy variant of a buddy that has already been chose" +
        "n (100 = 100%)\r\nEnemy variant example: a small dog that inflicts rot is a small " +
        "dog variant.\r\n");
            this.n_variantReuseChance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cb_buddyReuse
            // 
            this.cb_buddyReuse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_buddyReuse.AutoSize = true;
            this.cb_buddyReuse.Location = new System.Drawing.Point(149, 94);
            this.cb_buddyReuse.Name = "cb_buddyReuse";
            this.cb_buddyReuse.Size = new System.Drawing.Size(127, 19);
            this.cb_buddyReuse.TabIndex = 50;
            this.cb_buddyReuse.Text = "Allow Buddy Reuse";
            this.toolTip1.SetToolTip(this.cb_buddyReuse, "Determines if a buddy that has already been selected can be chosen again.\r\nDoes n" +
        "ot affect Multi-buddy dupe chance (which only affects multi-buddies)");
            this.cb_buddyReuse.UseVisualStyleBackColor = true;
            this.cb_buddyReuse.CheckedChanged += new System.EventHandler(this.cb_buddyReuse_CheckedChanged);
            // 
            // cb_TeamAttack
            // 
            this.cb_TeamAttack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TeamAttack.AutoSize = true;
            this.cb_TeamAttack.Checked = true;
            this.cb_TeamAttack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TeamAttack.Location = new System.Drawing.Point(41, 412);
            this.cb_TeamAttack.Name = "cb_TeamAttack";
            this.cb_TeamAttack.Size = new System.Drawing.Size(182, 19);
            this.cb_TeamAttack.TabIndex = 67;
            this.cb_TeamAttack.Text = "Retain Team Attack Effectivity";
            this.toolTip1.SetToolTip(this.cb_TeamAttack, "If true, buddies will be less aggressive when multiple AI allies are attacking th" +
        "e same target.\r\nImpact depends on the buddy and how many allies are attacking th" +
        "e same target.");
            this.cb_TeamAttack.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(322, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = "HP Cost Chance";
            // 
            // max
            // 
            this.max.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(149, 165);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 15);
            this.max.TabIndex = 5;
            this.max.Text = "Multi-Buddy Max";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dupe Chance";
            // 
            // tb_settings
            // 
            this.tb_settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_settings.Location = new System.Drawing.Point(349, 357);
            this.tb_settings.Name = "tb_settings";
            this.tb_settings.PlaceholderText = "No Preset";
            this.tb_settings.Size = new System.Drawing.Size(118, 23);
            this.tb_settings.TabIndex = 57;
            this.tb_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_settings.TextChanged += new System.EventHandler(this.tb_settings_TextChanged);
            this.tb_settings.MouseEnter += new System.EventHandler(this.tb_settings_ManualToolTip);
            this.tb_settings.MouseLeave += new System.EventHandler(this.tb_settings_MouseLeave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(62, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Multi-Summons";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "FP Cost Min";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "FP Cost Max";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(361, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ash Stats";
            // 
            // t_console
            // 
            this.t_console.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.t_console.Location = new System.Drawing.Point(121, 467);
            this.t_console.Name = "t_console";
            this.t_console.ReadOnly = true;
            this.t_console.Size = new System.Drawing.Size(244, 23);
            this.t_console.TabIndex = 24;
            this.t_console.Text = "Waiting for regulation";
            this.t_console.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(349, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "RNG Control";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(322, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "HP Multiplier";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "HP Cost Max";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(322, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "HP Cost Min";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(60, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 25);
            this.label19.TabIndex = 49;
            this.label19.Text = "Initial Summons";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_info,
            this.settingsPresetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_info
            // 
            this.menu_info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_info.Name = "menu_info";
            this.menu_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_info.Size = new System.Drawing.Size(40, 20);
            this.menu_info.Text = "Info";
            this.menu_info.Click += new System.EventHandler(this.menu_info_Click);
            // 
            // settingsPresetsToolStripMenuItem
            // 
            this.settingsPresetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preset_fun,
            this.preset_reasonable,
            this.preset_CHAOS,
            this.preset_family,
            this.preset_playground,
            this.balancedToolStripMenuItem});
            this.settingsPresetsToolStripMenuItem.Name = "settingsPresetsToolStripMenuItem";
            this.settingsPresetsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.settingsPresetsToolStripMenuItem.Text = "Settings Presets";
            // 
            // preset_fun
            // 
            this.preset_fun.Name = "preset_fun";
            this.preset_fun.Size = new System.Drawing.Size(135, 22);
            this.preset_fun.Text = "Fun";
            this.preset_fun.Click += new System.EventHandler(this.preset_fun_Click);
            // 
            // preset_reasonable
            // 
            this.preset_reasonable.Name = "preset_reasonable";
            this.preset_reasonable.Size = new System.Drawing.Size(135, 22);
            this.preset_reasonable.Text = "Reasonable";
            this.preset_reasonable.Click += new System.EventHandler(this.preset_reasonable_Click);
            // 
            // preset_CHAOS
            // 
            this.preset_CHAOS.Name = "preset_CHAOS";
            this.preset_CHAOS.Size = new System.Drawing.Size(135, 22);
            this.preset_CHAOS.Text = "CHAOS";
            this.preset_CHAOS.Click += new System.EventHandler(this.preset_CHAOS_Click);
            // 
            // preset_family
            // 
            this.preset_family.Name = "preset_family";
            this.preset_family.Size = new System.Drawing.Size(135, 22);
            this.preset_family.Text = "Family";
            this.preset_family.Click += new System.EventHandler(this.preset_family_Click);
            // 
            // preset_playground
            // 
            this.preset_playground.Name = "preset_playground";
            this.preset_playground.Size = new System.Drawing.Size(135, 22);
            this.preset_playground.Text = "Playground";
            this.preset_playground.Click += new System.EventHandler(this.preset_playground_Click);
            // 
            // balancedToolStripMenuItem
            // 
            this.balancedToolStripMenuItem.Name = "balancedToolStripMenuItem";
            this.balancedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.balancedToolStripMenuItem.Text = "\"Balanced\"";
            this.balancedToolStripMenuItem.Click += new System.EventHandler(this.balancedToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(374, 390);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 52;
            this.label17.Text = "RNG Seed";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(360, 339);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "Settings Preset";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Initial Chance";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Additional Chance";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 15);
            this.label18.TabIndex = 48;
            this.label18.Text = "Allow Variant Chance";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(60, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Buddy Behavior";
            // 
            // combo_FollowBehavior
            // 
            this.combo_FollowBehavior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_FollowBehavior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_FollowBehavior.FormattingEnabled = true;
            this.combo_FollowBehavior.Items.AddRange(new object[] {
            "Follow the player",
            "Wander around",
            "Randomize per-buddy"});
            this.combo_FollowBehavior.Location = new System.Drawing.Point(58, 340);
            this.combo_FollowBehavior.Name = "combo_FollowBehavior";
            this.combo_FollowBehavior.Size = new System.Drawing.Size(138, 21);
            this.combo_FollowBehavior.TabIndex = 71;
            // 
            // combo_LargeFollowBehavior
            // 
            this.combo_LargeFollowBehavior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_LargeFollowBehavior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_LargeFollowBehavior.FormattingEnabled = true;
            this.combo_LargeFollowBehavior.Items.AddRange(new object[] {
            "Follow the player",
            "Wander around",
            "Randomize per-buddy"});
            this.combo_LargeFollowBehavior.Location = new System.Drawing.Point(58, 382);
            this.combo_LargeFollowBehavior.Name = "combo_LargeFollowBehavior";
            this.combo_LargeFollowBehavior.Size = new System.Drawing.Size(138, 21);
            this.combo_LargeFollowBehavior.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(41, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 15);
            this.label13.TabIndex = 73;
            this.label13.Text = "Follow Behavior";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(41, 364);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 15);
            this.label21.TabIndex = 74;
            this.label21.Text = "Large Buddy Follow Behavior";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 503);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.combo_LargeFollowBehavior);
            this.Controls.Add(this.combo_FollowBehavior);
            this.Controls.Add(this.cb_TeamAttack);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_bigBuddy);
            this.Controls.Add(this.b_restoreRegulation);
            this.Controls.Add(this.b_randomize);
            this.Controls.Add(this.b_browse);
            this.Controls.Add(this.b_settingsSet);
            this.Controls.Add(this.b_getSettings);
            this.Controls.Add(this.tb_settings);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cb_buddyReuse);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.n_variantReuseChance);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.n_hpChance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_hpMax);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.n_hpMin);
            this.Controls.Add(this.b_newSeed);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_randomseed);
            this.Controls.Add(this.n_rngSeed);
            this.Controls.Add(this.n_hpMult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t_console);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.n_fpMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.n_fpMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_multipleChanceAdditional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.n_multipleDupeChance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_damageMult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_multipleChanceBase);
            this.Controls.Add(this.max);
            this.Controls.Add(this.n_multipleMax);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Elden Ring Summon Randomizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_damageMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_rngSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_fpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_fpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_hpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleDupeChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleChanceBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_multipleChanceAdditional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_variantReuseChance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label12;
        private CheckBox cb_TeamAttack;
        private ComboBox combo_FollowBehavior;
        private ComboBox combo_LargeFollowBehavior;
        private Label label13;
        private Label label21;
    }
}