using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakeStopParams")]
	public partial class FCameraShakeStopParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CameraShakeStopParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraShakeStopParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraShakeStopParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraShakeStopParams A, FCameraShakeStopParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraShakeStopParams A, FCameraShakeStopParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraShakeStopParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bImmediately
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bImmediately, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bImmediately, __InBuffer);
				}
			}
		}

		private static uint __bImmediately = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}