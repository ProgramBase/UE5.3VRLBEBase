using Script.CoreUObject;
using Script.Library;

namespace Script.FieldNotification
{
	[PathName("/Script/FieldNotification.FieldNotificationId")]
	public partial class FFieldNotificationId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FieldNotification.FieldNotificationId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFieldNotificationId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFieldNotificationId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFieldNotificationId A, FFieldNotificationId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFieldNotificationId A, FFieldNotificationId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFieldNotificationId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName FieldName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldName, __InBuffer);
				}
			}
		}

		private static uint __FieldName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}