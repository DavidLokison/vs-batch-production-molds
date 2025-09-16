using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace BatchProductionMolds
{
    public class BlockBatchMold : BlockToolMold
    {
        public override WorldInteraction[] GetPlacedBlockInteractionHelp(IWorldAccessor world, BlockSelection selection, IPlayer forPlayer)
        {
            WorldInteraction[] interactions = base.GetPlacedBlockInteractionHelp(world, selection, forPlayer);
            foreach (WorldInteraction interaction in interactions)
            {
                if (interaction.ActionLangCode == "blockhelp-toolmold-takeworkitem")
                {
                    interaction.ActionLangCode = "batchmolds:blockhelp-batchmold-takeingots";
                }
            }
            return interactions;
        }
    }
}
