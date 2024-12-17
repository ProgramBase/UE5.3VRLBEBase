using Script.CoreUObject;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapePatternBrushWorldSpaceSettings")]
	public partial class FLandscapePatternBrushWorldSpaceSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LandscapeEditor.LandscapePatternBrushWorldSpaceSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapePatternBrushWorldSpaceSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapePatternBrushWorldSpaceSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapePatternBrushWorldSpaceSettings A, FLandscapePatternBrushWorldSpaceSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapePatternBrushWorldSpaceSettings A, FLandscapePatternBrushWorldSpaceSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapePatternBrushWorldSpaceSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector2D Origin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __InBuffer);
				}
			}
		}

		public float Rotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __InBuffer);
				}
			}
		}

		public bool bCenterTextureOnOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCenterTextureOnOrigin, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCenterTextureOnOrigin, __InBuffer);
				}
			}
		}

		public float RepeatSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RepeatSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RepeatSize, __InBuffer);
				}
			}
		}

		private static uint __Origin = 0;

		private static uint __Rotation = 0;

		private static uint __bCenterTextureOnOrigin = 0;

		private static uint __RepeatSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}