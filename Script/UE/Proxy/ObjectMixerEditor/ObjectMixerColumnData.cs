using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerColumnData")]
	public partial class FObjectMixerColumnData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ObjectMixerEditor.ObjectMixerColumnData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectMixerColumnData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectMixerColumnData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectMixerColumnData A, FObjectMixerColumnData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectMixerColumnData A, FObjectMixerColumnData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectMixerColumnData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ColumnName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColumnName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColumnName, __InBuffer);
				}
			}
		}

		public bool bShouldBeEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShouldBeEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShouldBeEnabled, __InBuffer);
				}
			}
		}

		private static uint __ColumnName = 0;

		private static uint __bShouldBeEnabled = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}