using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeInfoLayerSettings")]
	public partial class FLandscapeInfoLayerSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeInfoLayerSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeInfoLayerSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeInfoLayerSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeInfoLayerSettings A, FLandscapeInfoLayerSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeInfoLayerSettings A, FLandscapeInfoLayerSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeInfoLayerSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ULandscapeLayerInfoObject LayerInfoObj
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerInfoObj, __ReturnBuffer);

					return *(ULandscapeLayerInfoObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerInfoObj, __InBuffer);
				}
			}
		}

		public FName LayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerName, __InBuffer);
				}
			}
		}

		public UMaterialInstanceConstant ThumbnailMIC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ThumbnailMIC, __ReturnBuffer);

					return *(UMaterialInstanceConstant*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ThumbnailMIC, __InBuffer);
				}
			}
		}

		public ALandscapeProxy Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(ALandscapeProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public int DebugColorChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugColorChannel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugColorChannel, __InBuffer);
				}
			}
		}

		public bool bValid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bValid, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bValid, __InBuffer);
				}
			}
		}

		private static uint __LayerInfoObj = 0;

		private static uint __LayerName = 0;

		private static uint __ThumbnailMIC = 0;

		private static uint __Owner = 0;

		private static uint __DebugColorChannel = 0;

		private static uint __bValid = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}