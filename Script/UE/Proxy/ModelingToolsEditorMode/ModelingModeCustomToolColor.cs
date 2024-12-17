using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.ModelingModeCustomToolColor")]
	public partial class FModelingModeCustomToolColor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingToolsEditorMode.ModelingModeCustomToolColor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModelingModeCustomToolColor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModelingModeCustomToolColor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModelingModeCustomToolColor A, FModelingModeCustomToolColor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModelingModeCustomToolColor A, FModelingModeCustomToolColor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModelingModeCustomToolColor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ToolName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToolName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToolName, __InBuffer);
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

		private static uint __ToolName = 0;

		private static uint __Color = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}