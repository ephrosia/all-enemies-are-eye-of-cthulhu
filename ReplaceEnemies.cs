using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ReplaceEnemies
{
    public class ReplaceEnemiesMod : GlobalNPC
    {
        public override bool PreAI(NPC npc)
        {
            // Check if the NPC is an enemy (non-friendly)
            if (npc.friendly == false)
            {
                // Change the NPC type to the desired enemy type
                // Change the ID following NPCID. to the enemy
                // Use https://terraria.fandom.com/wiki/NPC_IDs for all NPC/Enemy IDs
                int replacementType = NPCID.EyeofCthulhu;

                if (npc.type != replacementType)
                {
                    int oldType = npc.type;
                    npc.Transform(replacementType);

                    // To prevent infinite recursion
                    if (npc.type == oldType)
                    {
                        return true;
                    }
                }
            }
            return base.PreAI(npc);
        }
    }
}
