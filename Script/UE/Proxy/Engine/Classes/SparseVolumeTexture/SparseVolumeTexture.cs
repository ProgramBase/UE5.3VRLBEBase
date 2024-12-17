using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SparseVolumeTexture")]
	public partial class USparseVolumeTexture : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SparseVolumeTexture");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int GetSizeZ()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSizeZ, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetSizeY()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSizeY, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetSizeX()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSizeX, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumMipLevels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumMipLevels, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __GetSizeZ = 0;

		private static uint __GetSizeY = 0;

		private static uint __GetSizeX = 0;

		private static uint __GetNumMipLevels = 0;

		private static uint __GetNumFrames = 0;
	}
}