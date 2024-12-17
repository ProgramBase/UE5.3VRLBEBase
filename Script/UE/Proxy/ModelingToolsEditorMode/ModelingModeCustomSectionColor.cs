using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.ModelingModeCustomSectionColor")]
	public partial class FModelingModeCustomSectionColor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingToolsEditorMode.ModelingModeCustomSectionColor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModelingModeCustomSectionColor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModelingModeCustomSectionColor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModelingModeCustomSectionColor A, FModelingModeCustomSectionColor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModelingModeCustomSectionColor A, FModelingModeCustomSectionColor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModelingModeCustomSectionColor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString SectionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionName, __InBuffer);
				}
			}
		}

		public FLinearColor Color
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Color, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Color, __InBuffer);
				}
			}
		}

		private static uint __SectionName = 0;

		private static uint __Color = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}