using SoulsFormats;
using Microsoft.VisualBasic.FileIO;

/*
 TODO (someday)
 * Figure out and handle buddy param "pay attention to player targeting".
 * Vague balancing: establish multiple sets of spEffects with diminished mults for multi-buddies
*/


namespace ER_Buddy_Randomizer
{
    public partial class MainForm : Form
    {
        public string backupFile = "";

        public List<string> settingsList = new();
        public Dictionary<string, string> presetList = new()
        {
            //list of settings presets
            { "default", "20,50,5,50,80,False,2,3,30,60,10,300,600,True,True,False,False," },
            { "fun", "20,50,5,50,80,False,2,3,30,60,10,300,600,True,True,False,False" },
            { "reasonable", "30,20,4,60,100,False,1.5,1.25,30,100,10,300,900,True,True,False,False," },
            { "chaos", "0,100,5,100,0,False,3,2,60,100,50,600,1000,False,False,False,True," },
            { "family", "50,100,8,80,100,False,1.5,2,30,60,10,300,600,False,True,True,False," },
            { "playground", "20,90,8,50,50,False,10,3,0,0,0,0,0,True,True,True,False," },
            { "balanced", "30,20,3,50,100,False,1,1,30,100,10,300,900,True,True,False,False," },
        };
        public List<int> npcBlacklist_BrokenAI = new()
        {
            //list of npc IDs to exclude since they just don't work at all
            //unimplemented
            0,
            //ancestor with staff?
            //bloodhound? (teleporting issue?)
            //radahn? (only one phase or another?)
            //astel?

        };
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            b_randomize.Enabled = false;
            b_restoreRegulation.Enabled = false;
            string version = Application.ProductVersion;
            Text = Text + string.Format(" {0}", version);
        }

        private static PARAM.Row InsertParamRow(PARAM param, PARAM.Row row, int newID)
        {
            PARAM.Row newRow = new PARAM.Row(newID, "buddyRando " + newID, param.AppliedParamdef);

            for (var i = 0; i < row.Cells.Count; i++)
            {
                newRow.Cells[i].Value = row.Cells[i].Value;
            }
            param.Rows.Insert(param.Rows.IndexOf(row) + 1, newRow);

            return newRow;
        }

        private void SettingsToString()
        {
            //read fields, set settings string
            //(nobody make fun of me for this shitty implementation, please.)

            settingsList.Clear();

            //place settings values into list
            //
            settingsList.Add(n_variantReuseChance.Value.ToString());
            settingsList.Add(n_multipleChanceBase.Value.ToString());
            settingsList.Add(n_multipleMax.Value.ToString());
            settingsList.Add(n_multipleChanceAdditional.Value.ToString());
            settingsList.Add(n_multipleDupeChance.Value.ToString());
            //
            settingsList.Add(cb_buddyReuse.Checked.ToString());
            settingsList.Add(n_hpMult.Value.ToString());
            settingsList.Add(n_damageMult.Value.ToString());
            settingsList.Add(n_fpMin.Value.ToString());
            settingsList.Add(n_fpMax.Value.ToString());
            //
            settingsList.Add(n_hpChance.Value.ToString());
            settingsList.Add(n_hpMin.Value.ToString());
            settingsList.Add(n_hpMax.Value.ToString());
            settingsList.Add(cb_bigBuddy.Checked.ToString());
            //1.1.0
            settingsList.Add(cb_SmallFollow.Checked.ToString());
            settingsList.Add(cb_BigFollow.Checked.ToString());
            settingsList.Add(cb_BuddySmell.Checked.ToString());


            string settingsString = "";
            foreach (string str in settingsList)
            {
                settingsString = settingsString+str + ",";
            }

            tb_settings.Text = settingsString;

            return;
        }
        private void StringToSettings()
        {
            //read settings string, set fields
            //(nobody make fun of me for this shitty implementation, please.)

            List<string> settingsList = tb_settings.Text.Split(",",StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> defaultSettings = presetList["default"].Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            //check and handle settings string being too short
            bool showWarning = false;
            if (settingsList.Count != defaultSettings.Count)
            {
                showWarning = true;
                //Update missing settings list entries with default settings values
                for (var i = settingsList.Count; i < defaultSettings.Count; i++)
                {
                    settingsList.Add(defaultSettings[i]);
                }
            }

            /*
            if (settingsList.Count != lastEntry + 1)
            {
                MessageBox.Show("Settings Preset has wrong number of settings.\n\nMake sure you properly copied and pasted the entire string.\nIf this setting preset is from a different version, it may be incompatible.", "Error", MessageBoxButtons.OK);
                return;
            }
            */

            /*
            if (settingsList.Count != lastEntry + 1)
            {
                MessageBox.Show("Settings Preset has wrong number of settings.\n\nMake sure you properly copied and pasted the entire string.\nIf this setting preset is from a different version, it may be incompatible.", "Error", MessageBoxButtons.OK);
                return;
            }
            */

            /*
            if (settingsList.Count != lastEntry + 1)
            {
                MessageBox.Show("Settings Preset has wrong number of settings.\n\nMake sure you properly copied and pasted the entire string.\nIf this setting preset is from a different version, it may be incompatible.", "Error", MessageBoxButtons.OK);
                return;
            }
            */

            try
            {
                //
                n_variantReuseChance.Value = decimal.Parse(settingsList[0]);
                n_multipleChanceBase.Value = decimal.Parse(settingsList[1]);
                n_multipleMax.Value = decimal.Parse(settingsList[2]);
                n_multipleChanceAdditional.Value = decimal.Parse(settingsList[3]);
                n_multipleDupeChance.Value = decimal.Parse(settingsList[4]);
                //
                cb_buddyReuse.Checked = bool.Parse(settingsList[5]); //bool
                n_hpMult.Value = decimal.Parse(settingsList[6]);
                n_damageMult.Value = decimal.Parse(settingsList[7]);
                n_fpMin.Value = decimal.Parse(settingsList[8]);
                n_fpMax.Value = decimal.Parse(settingsList[9]);
                //
                n_hpChance.Value = decimal.Parse(settingsList[10]);
                n_hpMin.Value = decimal.Parse(settingsList[11]);
                n_hpMax.Value = decimal.Parse(settingsList[12]);
                cb_bigBuddy.Checked = bool.Parse(settingsList[13]); //bool
                //1.1.0
                cb_SmallFollow.Checked = bool.Parse(settingsList[14]); //bool
                cb_BigFollow.Checked = bool.Parse(settingsList[15]); //bool
                cb_BuddySmell.Checked = bool.Parse(settingsList[16]); //bool

                if (showWarning)
                {
                    SettingsToString();
                    MessageBox.Show("Settings have been set successfully." +
                        "\nHowever, the Settings Preset was missing some settings: probably because of a Summon Randomizer update." +
                        "\n\nAny missing settings have been set to default, and the Settings Preset has been updated to include missing settings."
                        , "Notice", MessageBoxButtons.OK);
                }

                UpdateConsole("Applied Preset");
            }
            catch
            {
                MessageBox.Show("Settings Preset is invalid.\n\nMake sure you properly copy/pasted the entire string.", "Error", MessageBoxButtons.OK);
                return;
                //SettingsToString();
            }
            return;
        }

        private void CreateBuddy()
        {

            #region Load Parameters from Regulation.bin
            Dictionary<string, PARAM> paramList = new();
            string regulationPath = openFileDialog1.FileName;

            UpdateConsole("Checking Backup");
            if (!File.Exists(backupFile))
            {
                //no backup file exists
                UpdateConsole("Creating Backup");
                File.Copy(openFileDialog1.FileName, backupFile);
                b_restoreRegulation.Enabled = true;
            }

            UpdateConsole("Decrypting Regulation");

            BND4 paramBND = SFUtil.DecryptERRegulation(regulationPath); //load and decrypt param regulation

            UpdateConsole("Loading ParamDefs");

            var paramdefs = new List<PARAMDEF>();
            foreach (string path in Directory.GetFiles("Paramdex", "*.xml"))
            {
                var paramdef = PARAMDEF.XmlDeserialize(path);
                paramdefs.Add(paramdef);
            }

            UpdateConsole("Handling Params");

            foreach (BinderFile file in paramBND.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                var param = PARAM.Read(file.Bytes);

                // Recommended method: checks the list for any match, or you can test them one-by-one
                if (param.ApplyParamdefCarefully(paramdefs))
                    paramList[name] = param;

                // Alternative method: applies without any additional verification
                //param.ApplyParamdef(paramdefs.Find(def => def.ParamType == param.ParamType));
                //paramList[name] = param;
            }
            #endregion

            UpdateConsole("Modifying Params");

            PARAM buddyParam = paramList["BuddyParam"];
            PARAM npcParam = paramList["NpcParam"];
            PARAM npcThinkParam = paramList["NpcThinkParam"];
            PARAM goodsParam = paramList["EquipParamGoods"];
            PARAM spEffectParam = paramList["SpEffectParam"];

            //initialize RNG
            int rngSeed = (int)n_rngSeed.Value;
            if (rngSeed == -1)
            {
                //if no seed was provided, generate a new one
                Random newSeed = new Random();
                n_rngSeed.Value = newSeed.Next(1, 999999999);
                rngSeed = (int)n_rngSeed.Value;
            }
            Random rng = new(rngSeed);

            SettingsToString();//update settings string

            #region Cleanup & Randomizer Logic 1
            //Clean buddyParam BuddyParam entry groundwork
            for (int i = 0; i < buddyParam.Rows.Count; i++)
            {
                PARAM.Row row = buddyParam.Rows[i];

                //Clean up buddy params
                if (row.ID == 0)
                    continue;
                else if (row.ID % 100 != 0)
                {
                    //row is for an additional buddy, nuke it
                    buddyParam.Rows.Remove(row);
                    i--; //decrement to account for the removed row
                    continue;
                }
                row["npcParamId"].Value = -1; //needs to be cleared for variant logic

                //Logic 1
                //Decide how many buddies this summon should have
                if (rng.Next(1, 100) <= n_multipleChanceBase.Value && n_multipleMax.Value > 1)
                {
                    //is a multi-summon
                    InsertParamRow(buddyParam, buddyParam.Rows[i], buddyParam.Rows[i].ID + 1);
                    i++; //skip inserted row for the next loop

                    for (int ii = 1; ii < n_multipleMax.Value; ii++) //ii = 1 since the first multi-buddy has already been implemented above
                    {
                        if (rng.Next(1, 100) <= n_multipleChanceAdditional.Value)
                        {
                            InsertParamRow(buddyParam, buddyParam.Rows[i], buddyParam.Rows[i].ID + 1);
                            i++; //skip inserted row for the next loop
                        }
                    }
                }
            }
            int buddyParamCount = buddyParam.Rows.Count;
            #endregion

            #region Get Valid NPCs
            //create list of valid npcParam and npcThinkParam
            List<int> goodNpcIDs = new();
            List<int> goodNpcThinkIDs = new();
            foreach (PARAM.Row NpcRow in npcParam.Rows.ToList())
            {
                int npcID = NpcRow.ID;

                /*
                //DEBUG
                float mySizeTest = (float)NpcRow["hitHeight"].Value + (float)NpcRow["hitRadius"].Value;
                if (mySizeTest < 6)
                {
                    continue;
                }
                */
                
                if ((Int32)npcParam[npcID]["behaviorVariationId"].Value > 10000 //not a c0000 NPC
                //&& npcID < 1000000000 //not a spirit ash npc
                    && npcID < 89000000) //not a cutscene NPC (probably) (this disallows some c0000's fyi. maybe just non-combat ones though.)
                {

                    //figure out the best npcThinkID to use
                    for (int i = npcThinkParam.Rows.Count - 1; i >= 0; i--) //iterate backwards to catch the juicy variant IDs first
                    {
                        PARAM.Row row2 = npcThinkParam.Rows[i];
                        if (npcID == row2.ID
                        || npcID - npcID % 10 == row2.ID
                        || npcID - npcID % 100 == row2.ID
                        || npcID - npcID % 1000 == row2.ID
                        || npcID - npcID % 10000 == row2.ID
                        || npcID - npcID % 100000 == row2.ID)
                        {
                            goodNpcIDs.Add(npcID);
                            goodNpcThinkIDs.Add(row2.ID);
                            break;
                        }
                        else if (i == 0)
                        {
                            //throw new InvalidOperationException("Couldn't find an NpcThinkParam entry! Weird, right?");
                            MessageBox.Show("Couldn't find a good NpcThinkParam entry!\nOffending NpcParam ID: " + npcID + "\n\nPlease send me a message (@king_bore_haha) with this error message and ID!", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            #endregion

            #region Randomizer Logic 2
            for (int i = 0; i < buddyParamCount; i++)
            {
                PARAM.Row buddyParamRow = buddyParam.Rows[i];
                Int32 npcID;
                Int32 npcThinkID;

                //skip row ID 0
                if (buddyParamRow.ID == 0)
                    continue;

                if (goodNpcIDs.Count == 0)
                {
                    //error: good NPC IDs has ran out, but the program wants to still run
                    MessageBox.Show("Ran out of NPC IDs to use! This is probably because you are requesting too many unique multi-buddies. Try enabling buddy reuse, or reducing multi-buddy chances.\n\nIf this happens with reasonable settings, please send me a message (@king_bore_haha) with this error message and let me know if your game was already modded!", "Error", MessageBoxButtons.OK);
                    ActiveForm.Close(); //close the program
                }

                //decide which NpcParam entries to use
                int rng_index = rng.Next(0, goodNpcIDs.Count); //pick next random entry


                //check if chosen NPC is acceptable
                int timeout = 0;
                for (var iLogic = 0; iLogic < buddyParam.Rows.Count; iLogic++)
                {
                    int buddyNpcChoice = (int)buddyParam.Rows[iLogic]["npcParamId"].Value;
                    int npcChoice = goodNpcIDs[rng_index];

                    //variant check
                    if (cb_buddyReuse.Checked == false
                        && npcChoice - npcChoice % 1000 == buddyNpcChoice - buddyNpcChoice % 1000)
                    {
                        //chosen NPC is a variant
                        if (rng.Next(1, 100) <= n_variantReuseChance.Value)
                        {
                            //variant is accepted, leave loop
                            break;
                        }
                        else
                        {
                            //variant denied, choose a different entry
                            if (timeout < 1000000)
                            {
                                rng_index = rng.Next(0, goodNpcIDs.Count);
                            }
                            else
                            {
                                //change selection method to iterative if RNG fails an insane number of times
                                rng_index++;
                                if (rng_index >= goodNpcIDs.Count)
                                    rng_index = 0;
                            }
                            iLogic = -1; //reset loop
                        }
                    }
                    //size check
                    else if (buddyParamRow.ID % 100 != 0)
                    {
                        //is a multi-buddy
                        PARAM.Row chosenNpcRow = npcParam[npcChoice];
                        float mySize = (float)chosenNpcRow["hitHeight"].Value + (float)chosenNpcRow["hitRadius"].Value;
                        float sizeThreshold = 6;

                        if (mySize > sizeThreshold)
                        {
                            //size denied, choose a different entry
                            if (timeout < 1000000)
                            {
                                rng_index = rng.Next(0, goodNpcIDs.Count);
                            }
                            else
                            {
                                //change selection method to iterative if RNG fails an insane number of times
                                rng_index++;
                                if (rng_index >= goodNpcIDs.Count)
                                    rng_index = 0;
                            }
                            iLogic = -1; //reset loop
                        }
                    }
                    //edge case timeout check
                    timeout++;
                    if (timeout >= 3000000 + goodNpcIDs.Count)
                    {
                        MessageBox.Show("Got stuck in NPC choice logic! This is probably because you are requesting too many unique multi-buddies. Try reducing multi-buddy chances, or enabling buddy reuse.\n\nIf this happens with a default preset (or very easily), please send me a message with this error message and let me know if your game was already modded!", "Error", MessageBoxButtons.OK);
                        ActiveForm.Close(); //close the program
                    }
                }

                bool isMultiSummon = buddyParamRow.ID - buddyParam.Rows[i - 1].ID == 1;
                if (isMultiSummon
                && rng.Next(1, 100) <= n_multipleDupeChance.Value) //should this be a dupe summon
                {
                    //this is multi-summon, and will be a dupe of the first entry
                    int buddyBaseID = buddyParamRow.ID - buddyParamRow.ID % 100;
                    npcID = (Int32)buddyParam[buddyBaseID]["npcParamId"].Value;
                    npcThinkID = (Int32)buddyParam[buddyBaseID]["npcThinkParamId"].Value;
                }
                else
                {
                    //summon is not a dupe

                    npcID = goodNpcIDs[rng_index];
                    npcThinkID = goodNpcThinkIDs[rng_index];
                    if (cb_buddyReuse.Checked == false)
                    {
                        //Remove entries if Buddy Reuse is disabled
                        goodNpcIDs.Remove(rng_index);
                        goodNpcThinkIDs.Remove(rng_index);
                    }
                }
                #endregion

                #region NpcParam
                //create and modify new npcParam entry
                int newNpcID = npcID;
                do
                {
                    newNpcID++; //increment until ID is free
                }
                while (npcParam[newNpcID] != null);

                PARAM.Row newNpcRow = InsertParamRow(npcParam, npcParam[npcID], newNpcID);

                /*
                UInt32 baseHP = (UInt32)newNpcRow["hp"].Value;
                float maxHPMod = (float)n_hpMult.Value;
                newNpcRow["hp"].Value = (UInt32)Math.Floor(baseHP * maxHPMod); //add onto existing multiplier
                */

                newNpcRow["teamType"].Value = (byte)47; //spirit summon
                newNpcRow["itemLotId_enemy"].Value = -1;
                newNpcRow["itemLotId_map"].Value = -1;
                newNpcRow["GameClearSpEffectID"].Value = -1;
                newNpcRow["getSoul"].Value = (uint)0;

                //max map hit radii to prevent spawning issues
                float maxHitRadius = 1; //very low!
                float maxHitHeight = 5; //this could probably be tested more
                if ((float)newNpcRow["hitRadius"].Value > maxHitRadius)
                {
                    newNpcRow["hitRadius"].Value = maxHitRadius;
                }
                if ((float)newNpcRow["hitHeight"].Value > maxHitHeight)
                {
                    newNpcRow["hitHeight"].Value = maxHitHeight;
                }

                //npcParam Special Effects
                int[] buddyEffects = { 295000, 296000, 297000 }; //special effects to be inserted into new npcParam
                int iBuddy = 0;
                for (var iEffect = 0; iEffect <= 31; iEffect++)
                {
                    int effectID = (int)newNpcRow["spEffectID" + iEffect].Value;
                    if (effectID >= 7000 && effectID < 7700)
                    {
                        //slot contains a regular scaling spEffect. Destroy it.
                        newNpcRow["spEffectID" + iEffect].Value = -1;
                    }

                    if (effectID != -1 && iBuddy < buddyEffects.Length)
                    {
                        //slot is empty. insert buddy effects
                        newNpcRow["spEffectID" + iEffect].Value = buddyEffects[iBuddy];
                        iBuddy++;
                    }
                }
                if (iBuddy < buddyEffects.Length)
                {
                    MessageBox.Show("Couldn't find enough empty effect slots.\nOffending NpcParam ID: " + npcID + "\n\nPlease send me a message (@king_bore_haha) with this error message and ID!", "Error", MessageBoxButtons.OK);
                }
                #endregion

                #region BuddyParam
                buddyParamRow["npcParamId"].Value = newNpcID;

                buddyParamRow["npcThinkParamId"].Value = npcThinkID;
                buddyParamRow["npcPlayerInitParamId"].Value = -1; //some c0000 thing i think

                buddyParamRow["npcParamId_ridden"].Value = -1;
                buddyParamRow["npcThinkParamId_ridden"].Value = -1;
                buddyParamRow["generateAnimId"].Value = -1;
                buddyParamRow["appearOnAroundSekihi"].Value = (byte)0; //always summon around player
                buddyParamRow["pcFollowType"].Value = (byte)0; //0 = follow player around, 1 = don't?, 2 = ?



                //spawn offsets
                //this is all pretty dumb and I hate it
                /* //Horizontal offset 2 (I was right about being wrong. There isn't a height offset)
                float buddyHeight = (float)newNpcRow["hitHeight"].Value;
                buddyParamRow["z_offset"].Value = buddyHeight * buddyHeightMult * -1; //horizontal offset 2
                */
                float xOffset = 0;
                float buddyWidth = (float)newNpcRow["chrHitRadius"].Value;// * (float).75;
                if (isMultiSummon)
                {
                    float xOffsetIncrement = buddyWidth;

                    //this part doesn't actually make sense, but whatever.
                    xOffset = (float)buddyParam.Rows[i - 1]["x_offset"].Value;
                    if (xOffset >= 0)
                        xOffset += xOffsetIncrement; //increment
                    else
                        xOffset -= xOffsetIncrement; //decrement
                    xOffset *= -1; //invert

                }
                buddyParamRow["x_offset"].Value = xOffset; //horizontal offset 1
                buddyParamRow["z_offset"].Value = buddyWidth * -1; //horizontal offset 2


                //special effect scalers
                for (var iLv = 0; iLv <= 10; iLv++)
                {
                    buddyParamRow["dopingSpEffect_lv" + iLv].Value = 290000 + iLv; //buddy reinforcement spEfects
                }
                #endregion

                #region npcThinkParam
                npcThinkParam[npcThinkID]["isBuddyAI"].Value = true;
                npcThinkParam[npcThinkID]["TeamAttackEffectivity"].Value = (byte)0; //vaguely want this to potentially be non-zero in consideration of multi buddies. hmm
                #endregion
            }

            #region SpEffectParam
            //modify spEffects scalers used for buddy reinforcement
            for (var i = 0; i <= 10; i++)
            {
                //spEffects
                PARAM.Row spEffectRow = spEffectParam[290000 + i];
                float hpMult = (float)n_hpMult.Value - 1; //1.5 = + .5, .5 = -.5
                float damMult = (float)n_damageMult.Value - 1; //1.5 = + .5, .5 = -.5
                spEffectRow["maxHpRate"].Value = (float)spEffectRow["maxHpRate"].Value + hpMult;
                spEffectRow["physicsAttackPowerRate"].Value = (float)spEffectRow["physicsAttackPowerRate"].Value + damMult;
                spEffectRow["magicAttackPowerRate"].Value = (float)spEffectRow["magicAttackPowerRate"].Value + damMult;
                spEffectRow["fireAttackPowerRate"].Value = (float)spEffectRow["fireAttackPowerRate"].Value + damMult;
                spEffectRow["thunderAttackPowerRate"].Value = (float)spEffectRow["thunderAttackPowerRate"].Value + damMult;
                spEffectRow["darkAttackPowerRate"].Value = (float)spEffectRow["darkAttackPowerRate"].Value + damMult;
            }
            #endregion

            #region GoodsParam
            //randomize FP/HP cost
            foreach (PARAM.Row row in goodsParam.Rows)
            {
                if (row.ID >= 200000 && row.ID <= 270000) //can probably replace this with good type check, or a sort ID check or something. ashes are distinguished in the UI somehow, after all.
                {
                    //this is a spirit ash good
                    row["consumeHP"].Value = (Int16)0;
                    row["consumeMP"].Value = (Int16)0;

                    if (row.ID % 100 == 0)
                    {
                        //this is a +0 spirit ash, randomize costs
                        if (rng.Next(1, 100) <= n_hpChance.Value)
                        {
                            //costs HP
                            Int16 HPCost = (Int16)rng.Next((int)n_hpMin.Value, (int)n_hpMax.Value);
                            row["consumeHP"].Value = HPCost;
                        }
                        else
                        {
                            //costs FP
                            Int16 FPCost = (Int16)rng.Next((int)n_fpMin.Value, (int)n_fpMax.Value);
                            row["consumeMP"].Value = FPCost;
                        }
                    }
                    else
                    {
                        //this is NOT +0, copy costs from previous row
                        row["consumeHP"].Value = goodsParam[row.ID - 1]["consumeHP"].Value;
                        row["consumeMP"].Value = goodsParam[row.ID - 1]["consumeMP"].Value;

                    }
                }
            }
            #endregion

            UpdateConsole("Exporting Params");

            //output regulation
            foreach (BinderFile file in paramBND.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                if (paramList.ContainsKey(name))
                    file.Bytes = paramList[name].Write();
            }

            SFUtil.EncryptERRegulation(regulationPath, paramBND); //encrypt and write param regulation

        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string? directory = Path.GetDirectoryName(openFileDialog1.FileName);
                if (directory != null && File.Exists(directory + "\\eldenring.exe"))
                {
                    //user is loading the regulation next to eldenring.exe, yell at them

                    DialogResult result = MessageBox.Show("Warning: Modifying the Regulation.bin directly used by Elden Ring is ill-advised, as it's possible you may be banned."
                        + " \nIt's highly recommended you instead use Mod Engine 2 and modify a copy of Regulation.bin."
                        + " \n\nAre you sure you want to load the Regulation.bin you selected?"
                        , "Confirm Regulation.bin Selection", MessageBoxButtons.OKCancel);
                    if (result != DialogResult.OK)
                    {
                        b_randomize.Enabled = false;
                        return;
                    }
                }

                b_randomize.Enabled = true;

                UpdateConsole("Selected Regulation.bin");

                backupFile = directory + "/regulation.bin.backup"; //place backup next to regulation.bin

                if (File.Exists(backupFile))
                    b_restoreRegulation.Enabled = true;
            }
        }

        public void UpdateConsole(string text)
        {
            t_console.Text = text;
            Application.DoEvents();
        }

        private void b_randomize_Click(object sender, EventArgs e)
        {
            //start randomizer

             if (File.Exists(backupFile))
                {
                    //User wants to randomize a regulation that has a backup file next to it

                    DialogResult result = MessageBox.Show("Warning: Backup Regulation.bin already exists."
                        + " \nYou may be trying to randomize an already randomized Regulation.bin, which will cause issues. It's recommended you restore the backup first."
                        + " \n\nDelete Regulation.bin and restore backup before proceeding?"
                        , "Confirm Randomization", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.OK)
                    {
                        Restore_Regulation();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
             }

            CreateBuddy(); //Do everything

            GC.Collect(); //free memory

            UpdateConsole("Finished!");
            System.Media.SystemSounds.Exclamation.Play(); //make noise
            MessageBox.Show("All done!","Randomization Finished",MessageBoxButtons.OK);

        }

        private void n_rngSeed_ValueChanged(object sender, EventArgs e)
        {
            /*
            if (n_rngSeed.Value > 0) //don't choose a random seed
                label_randomseed.Visible = false;
            else
                label_randomseed.Visible = true;
            */
        }

        private void b_newSeed_Click(object sender, EventArgs e)
        {
            Random newSeed = new Random();
            n_rngSeed.Value = newSeed.Next(1, 999999999);
            UpdateConsole("Generated New Seed");
        }

        private void cb_buddyReuse_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_buddyReuse.Checked)
                n_variantReuseChance.Enabled = false;  
            else
                n_variantReuseChance.Enabled = true;
        }

        private void menu_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hover over an option to see what it does.\n\n" +
                "Remember: use this with Mod Engine 2 and don't use modded saves online, or else you might get banned!\n" +
                "Made by King Bore Haha / Geeeeeorge"
                , "Info", MessageBoxButtons.OK);

        }

        private void b_settingsSet_Click(object sender, EventArgs e)
        {
            StringToSettings();
        }

        private void b_getSettings_Click(object sender, EventArgs e)
        {
            SettingsToString();
        }

        private void tb_settings_ManualToolTip(object sender, EventArgs e)
        {
            //manual tooltip. because tooltips for text boxes is currently bugged
            toolTip1.Show("Used to save/restore Randomizer settings.\nCopy along with RNG Seed for consistent randomization.", tb_settings, 12, 20);
        }

        private void tb_settings_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(tb_settings);
        }

        private void tb_settings_TextChanged(object sender, EventArgs e)
        {
            if (tb_settings.Text != "")
                b_settingsSet.Enabled = true;
            else
                b_settingsSet.Enabled = false;
        }

        private void Restore_Regulation()
        {
            string regulationPath = openFileDialog1.FileName;
            
            FileSystem.DeleteFile(regulationPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            File.Move(backupFile, regulationPath, false);
            UpdateConsole("Backup Restored");
            b_restoreRegulation.Enabled = false;
            
        }

        private void b_restoreRegulation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Regulation.bin and restore backup?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Restore_Regulation();
        }

        private void n_fpMin_ValueChanged(object sender, EventArgs e)
        {
            if (n_fpMin.Value > n_fpMax.Value)
                n_fpMax.Value = n_fpMin.Value;
        }

        private void n_fpMax_ValueChanged(object sender, EventArgs e)
        {

            if (n_fpMin.Value > n_fpMax.Value)
                n_fpMin.Value = n_fpMax.Value;
        }

        private void n_hpMin_ValueChanged(object sender, EventArgs e)
        {
            if (n_hpMin.Value > n_hpMax.Value)
                n_hpMax.Value = n_hpMin.Value;
        }

        private void n_hpMax_ValueChanged(object sender, EventArgs e)
        {
            if (n_hpMin.Value > n_hpMax.Value)
                n_hpMin.Value = n_hpMax.Value;
        }

        private void preset_fun_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["fun"];
            StringToSettings();
        }

        private void preset_reasonable_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["reasonable"];
            StringToSettings();
        }

        private void preset_CHAOS_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["chaos"];
            StringToSettings();
        }

        private void preset_family_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["family"];
            StringToSettings();
        }

        private void preset_playground_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["playground"];
            StringToSettings();
        }

        private void balancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_settings.Text = presetList["balanced"];
            StringToSettings();
        }
    }
}