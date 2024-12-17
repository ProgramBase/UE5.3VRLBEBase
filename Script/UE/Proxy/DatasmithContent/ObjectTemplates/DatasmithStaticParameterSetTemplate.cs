using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithStaticParameterSetTemplate")]
	public partial class FDatasmithStaticParameterSetTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithStaticParameterSetTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithStaticParameterSetTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithStaticParameterSetTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithStaticParameterSetTemplate A, FDatasmithStaticParameterSetTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithStaticParameterSetTemplate A, FDatasmithStaticParameterSetTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithStaticParameterSetTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, bool> StaticSwitchParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameters, __ReturnBuffer);

					return *(TMap<FName, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameters, __InBuffer);
				}
			}
		}

		private static uint __StaticSwitchParameters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}