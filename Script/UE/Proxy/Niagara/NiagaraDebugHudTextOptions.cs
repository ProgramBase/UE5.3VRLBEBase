using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDebugHudTextOptions")]
	public partial class FNiagaraDebugHudTextOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDebugHudTextOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDebugHudTextOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDebugHudTextOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDebugHudTextOptions A, FNiagaraDebugHudTextOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDebugHudTextOptions A, FNiagaraDebugHudTextOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDebugHudTextOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ENiagaraDebugHudFont Font
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Font, __ReturnBuffer);

					return *(ENiagaraDebugHudFont*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Font, __InBuffer);
				}
			}
		}

		public ENiagaraDebugHudHAlign HorizontalAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __ReturnBuffer);

					return *(ENiagaraDebugHudHAlign*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __InBuffer);
				}
			}
		}

		public ENiagaraDebugHudVAlign VerticalAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VerticalAlignment, __ReturnBuffer);

					return *(ENiagaraDebugHudVAlign*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VerticalAlignment, __InBuffer);
				}
			}
		}

		public FVector2D ScreenOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScreenOffset, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScreenOffset, __InBuffer);
				}
			}
		}

		private static uint __Font = 0;

		private static uint __HorizontalAlignment = 0;

		private static uint __VerticalAlignment = 0;

		private static uint __ScreenOffset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}