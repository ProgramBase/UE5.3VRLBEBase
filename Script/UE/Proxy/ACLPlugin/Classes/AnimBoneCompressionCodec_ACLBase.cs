using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLBase")]
	public partial class UAnimBoneCompressionCodec_ACLBase : UAnimBoneCompressionCodec, IStaticClass
	{
		public ACLCompressionLevel CompressionLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionLevel, __ReturnBuffer);

					return *(ACLCompressionLevel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionLevel, __InBuffer);
				}
			}
		}

		public float DefaultVirtualVertexDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultVirtualVertexDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultVirtualVertexDistance, __InBuffer);
				}
			}
		}

		public float SafeVirtualVertexDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SafeVirtualVertexDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SafeVirtualVertexDistance, __InBuffer);
				}
			}
		}

		public float ErrorThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ErrorThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ErrorThreshold, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CompressionLevel = 0;

		private static uint __DefaultVirtualVertexDistance = 0;

		private static uint __SafeVirtualVertexDistance = 0;

		private static uint __ErrorThreshold = 0;
	}
}