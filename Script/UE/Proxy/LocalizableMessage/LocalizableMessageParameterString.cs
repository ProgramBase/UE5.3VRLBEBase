﻿using Script.CoreUObject;
using Script.Library;

namespace Script.LocalizableMessage
{
	[PathName("/Script/LocalizableMessage.LocalizableMessageParameterString")]
	public partial class FLocalizableMessageParameterString : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LocalizableMessage.LocalizableMessageParameterString");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizableMessageParameterString() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizableMessageParameterString() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizableMessageParameterString A, FLocalizableMessageParameterString B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizableMessageParameterString A, FLocalizableMessageParameterString B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizableMessageParameterString;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}