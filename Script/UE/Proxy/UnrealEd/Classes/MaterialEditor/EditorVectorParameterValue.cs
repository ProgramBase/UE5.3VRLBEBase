using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorVectorParameterValue")]
	public partial class FEditorVectorParameterValue : FEditorParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorVectorParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorVectorParameterValue()
		{
		}

		public static bool operator ==(FEditorVectorParameterValue A, FEditorVectorParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorVectorParameterValue A, FEditorVectorParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorVectorParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLinearColor ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		private static uint __ParameterValue = 0;

	}
}