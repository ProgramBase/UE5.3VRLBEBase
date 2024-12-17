using Script.CoreUObject;
using Script.Library;
using Script.Chaos;

namespace Script.Engine
{
	[PathName("/Script/Engine.ChaosPhysicsSettings")]
	public partial class FChaosPhysicsSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ChaosPhysicsSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChaosPhysicsSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChaosPhysicsSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChaosPhysicsSettings A, FChaosPhysicsSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChaosPhysicsSettings A, FChaosPhysicsSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChaosPhysicsSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EChaosThreadingMode DefaultThreadingModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultThreadingModel, __ReturnBuffer);

					return *(EChaosThreadingMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultThreadingModel, __InBuffer);
				}
			}
		}

		public EChaosSolverTickMode DedicatedThreadTickMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DedicatedThreadTickMode, __ReturnBuffer);

					return *(EChaosSolverTickMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DedicatedThreadTickMode, __InBuffer);
				}
			}
		}

		public EChaosBufferMode DedicatedThreadBufferMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DedicatedThreadBufferMode, __ReturnBuffer);

					return *(EChaosBufferMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DedicatedThreadBufferMode, __InBuffer);
				}
			}
		}

		private static uint __DefaultThreadingModel = 0;

		private static uint __DedicatedThreadTickMode = 0;

		private static uint __DedicatedThreadBufferMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}