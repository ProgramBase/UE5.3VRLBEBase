using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputAxisConfigEntry")]
	public partial class FInputAxisConfigEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InputAxisConfigEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputAxisConfigEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputAxisConfigEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputAxisConfigEntry A, FInputAxisConfigEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputAxisConfigEntry A, FInputAxisConfigEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputAxisConfigEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName AxisKeyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AxisKeyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AxisKeyName, __InBuffer);
				}
			}
		}

		public FInputAxisProperties AxisProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AxisProperties, __ReturnBuffer);

					return *(FInputAxisProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AxisProperties, __InBuffer);
				}
			}
		}

		private static uint __AxisKeyName = 0;

		private static uint __AxisProperties = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}