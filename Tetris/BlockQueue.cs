using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlocks(),
            new LBlocks(),
            new OBlocks(),
            new SBlocks(),
            new TBlocks(),
            new ZBlocks()
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        public BlockQueue() 
        { 
            NextBlock = RandomBlocks();
        }

        private Block RandomBlocks()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetAndUpdate()
        {
            Block blocks = NextBlock;

            do
            {
                NextBlock = RandomBlocks() ;
            }
            while(blocks.Id == NextBlock.Id);

            return blocks;
        }
    }

}
