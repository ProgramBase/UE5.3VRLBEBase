using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorStaticComponentMaskParameterValue")]
	public partial class FEditorStaticComponentMaskParameterValue : FEditorParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorStaticComponentMaskParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorStaticComponentMaskParameterValue()
		{
		}

		public static bool operator ==(FEditorStaticComponentMaskParameterValue A, FEditorStaticComponentMaskParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorStaticComponentMaskParameterValue A, FEditorStaticComponentMaskParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorStaticComponentMaskParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FComponentMaskParameter ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(FComponentMaskParameter*)__ReturnBuffer;
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