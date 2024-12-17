using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeEditorLayerSettings")]
	public partial class FLandscapeEditorLayerSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeEditorLayerSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeEditorLayerSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeEditorLayerSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeEditorLayerSettings A, FLandscapeEditorLayerSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeEditorLayerSettings A, FLandscapeEditorLayerSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeEditorLayerSettings;

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

		public FString ReimportLayerFilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReimportLayerFilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReimportLayerFilePath, __InBuffer);
				}
			}
		}

		private static uint __LayerInfoObj = 0;

		private static uint __ReimportLayerFilePath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}