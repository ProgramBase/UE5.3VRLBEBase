using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraLensInterfaceClassSupport")]
	public partial class FCameraLensInterfaceClassSupport : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CameraLensInterfaceClassSupport");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraLensInterfaceClassSupport() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraLensInterfaceClassSupport() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraLensInterfaceClassSupport A, FCameraLensInterfaceClassSupport B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraLensInterfaceClassSupport A, FCameraLensInterfaceClassSupport B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraLensInterfaceClassSupport;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<AActor> Class
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Class, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Class, __InBuffer);
				}
			}
		}

		private static uint __Class = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}