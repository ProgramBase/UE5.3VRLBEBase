using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosHandlerSet")]
	public partial class FChaosHandlerSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosSolverEngine.ChaosHandlerSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChaosHandlerSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChaosHandlerSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChaosHandlerSet A, FChaosHandlerSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChaosHandlerSet A, FChaosHandlerSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChaosHandlerSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<UObject> ChaosHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChaosHandlers, __ReturnBuffer);

					return *(TSet<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChaosHandlers, __InBuffer);
				}
			}
		}

		private static uint __ChaosHandlers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}