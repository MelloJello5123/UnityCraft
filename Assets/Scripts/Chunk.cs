	using UnityEngine;
	using System.Collections;
	using System;
	/*
	 * Use fucntion 'Start' for initialization
	 * Use function 'Update' for updating once per frame
	 */
public class Chunk : MonoBehaviour
{
	public int ChunkID;
	public Vector3 chunkSize;
	
	public Transform BottomBlock;
	public Transform StoneBlock;
	public Transform SandBlock;
	public Transform GrassBlock;
	
	System.Random random = new System.Random();
	public void Start()
	{
	}
	// Create a Chunk
	public void Create(Block[][][] block)
	{
		for(int x = 0; x < chunkSize.x; x++)
		{
			for(int y = 0; y < chunkSize.y; y++)
			{
				for(int z = 0; z < chunkSize.z; z++)
				{
					int d = random.NextDouble();
					// Pick the block types.
					if(d >= 0 && d <= 4)
					{
						block.Type = 1; // the block type is bottom block
					}
					
					if(d >= 4 && d <= 8)
					{
						block.Type = 2;
					}
					
					if(d >= 8 && d <= 11)
					{
						block.Type = 3;
					}
					
					if(d >= 11 && d <= 14)
					{
						block.Type = 4;
					}
				}
			}
		}
	}
	
	// Load a Chunk
	public void Load(int chunkID)
	{
		// TODO: Build a function that loads a chunk
	}
	
	// Render a chunk
	public void Render(Block block)
	{
		/*
		 * NOTES:
		 * 		note
		 * 
		 * TODO:
		 * 		Build a function that renders a chunk
		 */
		for(int x = 0; x < chunkSize.x; x++)
		{
			for(int y = 0; y < chunkSize.y; y++)
			{
				for (int z = 0; z < chunkSize.z; z++)
				{
					if(8 == 1)
					{
						// draw whatever
					}
				}
			}
		}
	}
	
	public class Block
	{
		public int x,y,z,Type;
		// public Vector4 blockInfo = new Vector4(); // x,y,z are the position of the block, w is the type of block.
	}
}