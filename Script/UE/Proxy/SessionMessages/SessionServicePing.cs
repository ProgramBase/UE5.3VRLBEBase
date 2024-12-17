using Script.CoreUObject;
using Script.Library;

namespace Script.SessionMessages
{
	[PathName("/Script/SessionMessages.SessionServicePing")]
	public partial class FSessionServicePing : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SessionMessages.SessionServicePing");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSessionServicePing() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSessionServicePing() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSessionServicePing A, FSessionServicePing B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSessionServicePing A, FSessionServicePing B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSessionServicePing;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString UserName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserName, __InBuffer);
				}
			}
		}

		private static uint __UserName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}