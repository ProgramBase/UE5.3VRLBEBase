using Script.CoreUObject;
using Script.Library;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.SolverRemovalFilterSettings")]
	public partial class FSolverRemovalFilterSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Chaos.SolverRemovalFilterSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSolverRemovalFilterSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSolverRemovalFilterSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSolverRemovalFilterSettings A, FSolverRemovalFilterSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSolverRemovalFilterSettings A, FSolverRemovalFilterSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSolverRemovalFilterSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool FilterEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterEnabled, __InBuffer);
				}
			}
		}

		public float MinMass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinMass, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinMass, __InBuffer);
				}
			}
		}

		public float MinVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinVolume, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinVolume, __InBuffer);
				}
			}
		}

		private static uint __FilterEnabled = 0;

		private static uint __MinMass = 0;

		private static uint __MinVolume = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}