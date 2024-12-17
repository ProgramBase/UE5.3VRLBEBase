using Script.CoreUObject;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageVertexColorChannelMask")]
	public partial class FFoliageVertexColorChannelMask : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Foliage.FoliageVertexColorChannelMask");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFoliageVertexColorChannelMask() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFoliageVertexColorChannelMask() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFoliageVertexColorChannelMask A, FFoliageVertexColorChannelMask B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFoliageVertexColorChannelMask A, FFoliageVertexColorChannelMask B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFoliageVertexColorChannelMask;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool UseMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UseMask, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UseMask, __InBuffer);
				}
			}
		}

		public float MaskThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaskThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaskThreshold, __InBuffer);
				}
			}
		}

		public bool InvertMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InvertMask, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InvertMask, __InBuffer);
				}
			}
		}

		private static uint __UseMask = 0;

		private static uint __MaskThreshold = 0;

		private static uint __InvertMask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}