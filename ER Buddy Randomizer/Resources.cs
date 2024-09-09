using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Buddy_Randomizer
{
    public class Resources
    {
        /// <summary>
        /// Object derived from .txt resource that contains a unique enemy's info.
        /// </summary>
        public class Enemy
        {
            public string Name;
            public int NpcID;
            public int ThinkID;
            public int CharaInitID;
            public List<int> BehaviorSpEffects;
            public Enemy(string name, int npcID, int thinkID, int charaInitID, List<int> behaviorSpEffects)
            {
                Name = name;
                NpcID = npcID;
                ThinkID = thinkID;
                CharaInitID = charaInitID;
                BehaviorSpEffects = behaviorSpEffects;
            }
        }

        public Dictionary<string, List<Enemy>> EnemyVariantDict = new();

        public void LoadEnemyResource()
        {
            string resourcePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\EnemyInfoResource.txt";
            if (!File.Exists(resourcePath))
            {
                throw new FileNotFoundException($"Cannot find file: Resources\\EnemyInfoResource.txt");
            }

            int lineNum = 0;
            try
            {
                var file = File.ReadAllLines(resourcePath);

                string variantKey = "";
                for (; lineNum < file.Length; lineNum++)
                {
                    var line = file[lineNum];
                    if (line.StartsWith("--"))
                    {
                        // Start of a new enemy section
                        variantKey = line[2..]; // Choose key name based on current line post-comment.
                        EnemyVariantDict[variantKey] = new List<Enemy>();
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var split = line.Split("||");
                    List<int> behaviorSpEffects = new();
                    if (split.Length == 5)
                    {
                        var effectSplit = split[4].Split(",");
                        foreach (var effect in effectSplit)
                        {
                            int effectID = int.Parse(effect);
                            if (effectID > 0)
                            {
                                behaviorSpEffects.Add(effectID);
                            }
                        }
                    }
                    Enemy newEnemy = new(split[0], int.Parse(split[1]), int.Parse(split[2]), int.Parse(split[3]), behaviorSpEffects);
                    EnemyVariantDict[variantKey].Add(newEnemy);
                }
                foreach (var dict in EnemyVariantDict.ToList())
                {
                    // Remove empty keys
                    if (!dict.Value.Any())
                    {
                        EnemyVariantDict.Remove(dict.Key);
                        continue;
                    }
                    EnemyVariantDict[dict.Key] = EnemyVariantDict[dict.Key].DistinctBy(e => e.Name).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error loading \"Resources\\EnemyInfoResource.txt\" on line {lineNum}", e);
            }
        }

    }
}
