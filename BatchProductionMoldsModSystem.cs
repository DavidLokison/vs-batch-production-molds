using BatchProductionMolds.ModContent;
using System;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace BatchProductionMolds
{
    public class BatchProductionMoldsModSystem : ModSystem
    {
        ICoreAPI? api;
        ICoreClientAPI? capi;
        ICoreServerAPI? sapi;

        public override void Start(ICoreAPI api)
        {
            this.api = api;
            
            RegisterBlocks();
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            this.capi = api;
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            this.sapi = api;
        }

        private void RegisterBlocks()
        {
            if (api == null) throw new NullReferenceException();
            api.RegisterBlockClass("BatchMolds.BlockBatchMold", typeof(BlockBatchMold));
        }
    }
}
