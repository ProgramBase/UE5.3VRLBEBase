using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.SortedParamData")]
	public partial class FSortedParamData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialEditor.SortedParamData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSortedParamData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSortedParamData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSortedParamData A, FSortedParamData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSortedParamData A, FSortedParamData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSortedParamData;

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