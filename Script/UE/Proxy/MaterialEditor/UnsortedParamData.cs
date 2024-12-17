using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.UnsortedParamData")]
	public partial class FUnsortedParamData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialEditor.UnsortedParamData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUnsortedParamData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUnsortedParamData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUnsortedParamData A, FUnsortedParamData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUnsortedParamData A, FUnsortedParamData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUnsortedParamData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UDEditorParameterValue Parameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parameter, __ReturnBuffer);

					return *(UDEditorParameterValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parameter, __InBuffer);
				}
			}
		}

		private static uint __Parameter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}