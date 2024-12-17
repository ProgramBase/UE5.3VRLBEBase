using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeLayerBrush")]
	public partial class FLandscapeLayerBrush : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeLayerBrush");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeLayerBrush() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeLayerBrush() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeLayerBrush A, FLandscapeLayerBrush B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeLayerBrush A, FLandscapeLayerBrush B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeLayerBrush;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ALandscapeBlueprintBrushBase BlueprintBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintBrush, __ReturnBuffer);

					return *(ALandscapeBlueprintBrushBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintBrush, __InBuffer);
				}
			}
		}

		private static uint __BlueprintBrush = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}