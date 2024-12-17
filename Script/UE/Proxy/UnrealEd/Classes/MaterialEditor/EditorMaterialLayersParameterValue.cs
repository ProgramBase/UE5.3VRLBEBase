using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorMaterialLayersParameterValue")]
	public partial class FEditorMaterialLayersParameterValue : FEditorParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorMaterialLayersParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorMaterialLayersParameterValue()
		{
		}

		public static bool operator ==(FEditorMaterialLayersParameterValue A, FEditorMaterialLayersParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorMaterialLayersParameterValue A, FEditorMaterialLayersParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorMaterialLayersParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialFunctionInterface FunctionValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionValue, __ReturnBuffer);

					return *(UMaterialFunctionInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionValue, __InBuffer);
				}
			}
		}

		private static uint __FunctionValue = 0;

	}
}