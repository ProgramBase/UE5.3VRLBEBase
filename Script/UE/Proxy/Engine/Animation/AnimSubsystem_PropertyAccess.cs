using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystem_PropertyAccess")]
	public partial class FAnimSubsystem_PropertyAccess : FAnimSubsystem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystem_PropertyAccess");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystem_PropertyAccess()
		{
		}

		public static bool operator ==(FAnimSubsystem_PropertyAccess A, FAnimSubsystem_PropertyAccess B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystem_PropertyAccess A, FAnimSubsystem_PropertyAccess B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystem_PropertyAccess;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPropertyAccessLibrary Library
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Library, __ReturnBuffer);

					return *(FPropertyAccessLibrary*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Library, __InBuffer);
				}
			}
		}

		private static uint __Library = 0;

	}
}