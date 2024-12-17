using Script.CoreUObject;
using Script.Library;

namespace Script.LocalizableMessage
{
	[PathName("/Script/LocalizableMessage.LocalizableMessageParameterFloat")]
	public partial class FLocalizableMessageParameterFloat : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LocalizableMessage.LocalizableMessageParameterFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizableMessageParameterFloat() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizableMessageParameterFloat() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizableMessageParameterFloat A, FLocalizableMessageParameterFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizableMessageParameterFloat A, FLocalizableMessageParameterFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizableMessageParameterFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}