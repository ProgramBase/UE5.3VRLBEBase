using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ISMClientData")]
	public partial class FISMClientData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ISMClientData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FISMClientData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FISMClientData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FISMClientData A, FISMClientData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FISMClientData A, FISMClientData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FISMClientData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FISMClientInstance> Instances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Instances, __ReturnBuffer);

					return *(TArray<FISMClientInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Instances, __InBuffer);
				}
			}
		}

		private static uint __Instances = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}