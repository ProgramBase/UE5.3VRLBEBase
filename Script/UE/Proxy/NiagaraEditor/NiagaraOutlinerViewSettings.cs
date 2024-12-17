using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraOutlinerViewSettings")]
	public partial class FNiagaraOutlinerViewSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraOutlinerViewSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerViewSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerViewSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerViewSettings A, FNiagaraOutlinerViewSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerViewSettings A, FNiagaraOutlinerViewSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerViewSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ENiagaraOutlinerViewModes ViewMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ViewMode, __ReturnBuffer);

					return *(ENiagaraOutlinerViewModes*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ViewMode, __InBuffer);
				}
			}
		}

		public FNiagaraOutlinerFilterSettings FilterSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterSettings, __ReturnBuffer);

					return *(FNiagaraOutlinerFilterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterSettings, __InBuffer);
				}
			}
		}

		public bool bSortDescending
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSortDescending, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSortDescending, __InBuffer);
				}
			}
		}

		public ENiagaraOutlinerSortMode SortMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SortMode, __ReturnBuffer);

					return *(ENiagaraOutlinerSortMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SortMode, __InBuffer);
				}
			}
		}

		public ENiagaraOutlinerTimeUnits TimeUnits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeUnits, __ReturnBuffer);

					return *(ENiagaraOutlinerTimeUnits*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeUnits, __InBuffer);
				}
			}
		}

		private static uint __ViewMode = 0;

		private static uint __FilterSettings = 0;

		private static uint __bSortDescending = 0;

		private static uint __SortMode = 0;

		private static uint __TimeUnits = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}