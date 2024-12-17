using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosDebugSubstepControl")]
	public partial class FChaosDebugSubstepControl : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosSolverEngine.ChaosDebugSubstepControl");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChaosDebugSubstepControl() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChaosDebugSubstepControl() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChaosDebugSubstepControl A, FChaosDebugSubstepControl B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChaosDebugSubstepControl A, FChaosDebugSubstepControl B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChaosDebugSubstepControl;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bPause
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPause, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPause, __InBuffer);
				}
			}
		}

		public bool bSubstep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSubstep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSubstep, __InBuffer);
				}
			}
		}

		public bool bStep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bStep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bStep, __InBuffer);
				}
			}
		}

		private static uint __bPause = 0;

		private static uint __bSubstep = 0;

		private static uint __bStep = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}