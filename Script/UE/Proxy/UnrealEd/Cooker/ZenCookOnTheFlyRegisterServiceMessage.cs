using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ZenCookOnTheFlyRegisterServiceMessage")]
	public partial class FZenCookOnTheFlyRegisterServiceMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.ZenCookOnTheFlyRegisterServiceMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FZenCookOnTheFlyRegisterServiceMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FZenCookOnTheFlyRegisterServiceMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FZenCookOnTheFlyRegisterServiceMessage A, FZenCookOnTheFlyRegisterServiceMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FZenCookOnTheFlyRegisterServiceMessage A, FZenCookOnTheFlyRegisterServiceMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FZenCookOnTheFlyRegisterServiceMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ServiceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ServiceId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ServiceId, __InBuffer);
				}
			}
		}

		public int Port
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Port, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Port, __InBuffer);
				}
			}
		}

		private static uint __ServiceId = 0;

		private static uint __Port = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}