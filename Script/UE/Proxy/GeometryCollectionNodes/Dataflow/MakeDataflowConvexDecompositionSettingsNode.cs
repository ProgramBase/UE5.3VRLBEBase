using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MakeDataflowConvexDecompositionSettingsNode")]
	public partial class FMakeDataflowConvexDecompositionSettingsNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MakeDataflowConvexDecompositionSettingsNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMakeDataflowConvexDecompositionSettingsNode()
		{
		}

		public static bool operator ==(FMakeDataflowConvexDecompositionSettingsNode A, FMakeDataflowConvexDecompositionSettingsNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMakeDataflowConvexDecompositionSettingsNode A, FMakeDataflowConvexDecompositionSettingsNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMakeDataflowConvexDecompositionSettingsNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MinSizeToDecompose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinSizeToDecompose, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinSizeToDecompose, __InBuffer);
				}
			}
		}

		public float MaxGeoToHullVolumeRatioToDecompose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxGeoToHullVolumeRatioToDecompose, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxGeoToHullVolumeRatioToDecompose, __InBuffer);
				}
			}
		}

		public float ErrorTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ErrorTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ErrorTolerance, __InBuffer);
				}
			}
		}

		public int MaxHullsPerGeometry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxHullsPerGeometry, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxHullsPerGeometry, __InBuffer);
				}
			}
		}

		public float MinThicknessTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinThicknessTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinThicknessTolerance, __InBuffer);
				}
			}
		}

		public int NumAdditionalSplits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumAdditionalSplits, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumAdditionalSplits, __InBuffer);
				}
			}
		}

		public FDataflowConvexDecompositionSettings DecompositionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DecompositionSettings, __ReturnBuffer);

					return *(FDataflowConvexDecompositionSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DecompositionSettings, __InBuffer);
				}
			}
		}

		private static uint __MinSizeToDecompose = 0;

		private static uint __MaxGeoToHullVolumeRatioToDecompose = 0;

		private static uint __ErrorTolerance = 0;

		private static uint __MaxHullsPerGeometry = 0;

		private static uint __MinThicknessTolerance = 0;

		private static uint __NumAdditionalSplits = 0;

		private static uint __DecompositionSettings = 0;

	}
}