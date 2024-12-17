using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.EnableStateEvent")]
	public partial class FEnableStateEvent : FCacheEventBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.EnableStateEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEnableStateEvent()
		{
		}

		public static bool operator ==(FEnableStateEvent A, FEnableStateEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEnableStateEvent A, FEnableStateEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEnableStateEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Index
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Index, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Index, __InBuffer);
				}
			}
		}

		public bool bEnable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnable, __InBuffer);
				}
			}
		}

		private static uint __Index = 0;

		private static uint __bEnable = 0;

	}
}