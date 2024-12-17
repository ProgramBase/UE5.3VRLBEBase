using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerCollectionObjectData")]
	public partial class FObjectMixerCollectionObjectData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ObjectMixerEditor.ObjectMixerCollectionObjectData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectMixerCollectionObjectData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectMixerCollectionObjectData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectMixerCollectionObjectData A, FObjectMixerCollectionObjectData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectMixerCollectionObjectData A, FObjectMixerCollectionObjectData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectMixerCollectionObjectData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath ObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __InBuffer);
				}
			}
		}

		private static uint __ObjectPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}