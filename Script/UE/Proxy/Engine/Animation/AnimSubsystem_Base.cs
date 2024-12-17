using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystem_Base")]
	public partial class FAnimSubsystem_Base : FAnimSubsystem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystem_Base");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystem_Base()
		{
		}

		public static bool operator ==(FAnimSubsystem_Base A, FAnimSubsystem_Base B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystem_Base A, FAnimSubsystem_Base B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystem_Base;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FExposedValueHandler> ExposedValueHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExposedValueHandlers, __ReturnBuffer);

					return *(TArray<FExposedValueHandler>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExposedValueHandlers, __InBuffer);
				}
			}
		}

		private static uint __ExposedValueHandlers = 0;

	}
}