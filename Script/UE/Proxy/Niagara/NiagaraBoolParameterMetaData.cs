using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraBoolParameterMetaData")]
	public partial class FNiagaraBoolParameterMetaData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraBoolParameterMetaData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraBoolParameterMetaData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraBoolParameterMetaData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraBoolParameterMetaData A, FNiagaraBoolParameterMetaData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraBoolParameterMetaData A, FNiagaraBoolParameterMetaData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraBoolParameterMetaData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ENiagaraBoolDisplayMode DisplayMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayMode, __ReturnBuffer);

					return *(ENiagaraBoolDisplayMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayMode, __InBuffer);
				}
			}
		}

		public FName OverrideNameTrue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNameTrue, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNameTrue, __InBuffer);
				}
			}
		}

		public FName OverrideNameFalse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNameFalse, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNameFalse, __InBuffer);
				}
			}
		}

		public UTexture2D IconOverrideTrue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IconOverrideTrue, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IconOverrideTrue, __InBuffer);
				}
			}
		}

		public UTexture2D IconOverrideFalse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IconOverrideFalse, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IconOverrideFalse, __InBuffer);
				}
			}
		}

		private static uint __DisplayMode = 0;

		private static uint __OverrideNameTrue = 0;

		private static uint __OverrideNameFalse = 0;

		private static uint __IconOverrideTrue = 0;

		private static uint __IconOverrideFalse = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}