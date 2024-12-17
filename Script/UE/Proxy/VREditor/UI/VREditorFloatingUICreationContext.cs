using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.UMG;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorFloatingUICreationContext")]
	public partial class FVREditorFloatingUICreationContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/VREditor.VREditorFloatingUICreationContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVREditorFloatingUICreationContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVREditorFloatingUICreationContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVREditorFloatingUICreationContext A, FVREditorFloatingUICreationContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVREditorFloatingUICreationContext A, FVREditorFloatingUICreationContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVREditorFloatingUICreationContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UUserWidget> WidgetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WidgetClass, __ReturnBuffer);

					return *(TSubclassOf<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WidgetClass, __InBuffer);
				}
			}
		}

		public FName PanelID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PanelID, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PanelID, __InBuffer);
				}
			}
		}

		public AActor ParentActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentActor, __InBuffer);
				}
			}
		}

		public FTransform PanelSpawnOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PanelSpawnOffset, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PanelSpawnOffset, __InBuffer);
				}
			}
		}

		public FVector2D PanelSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PanelSize, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PanelSize, __InBuffer);
				}
			}
		}

		public UStaticMesh PanelMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PanelMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PanelMesh, __InBuffer);
				}
			}
		}

		public float EditorUISize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorUISize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorUISize, __InBuffer);
				}
			}
		}

		public bool bHideWindowHandles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideWindowHandles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideWindowHandles, __InBuffer);
				}
			}
		}

		public bool bMaskOutWidgetBackground
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMaskOutWidgetBackground, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMaskOutWidgetBackground, __InBuffer);
				}
			}
		}

		public bool bNoCloseButton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNoCloseButton, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNoCloseButton, __InBuffer);
				}
			}
		}

		private static uint __WidgetClass = 0;

		private static uint __PanelID = 0;

		private static uint __ParentActor = 0;

		private static uint __PanelSpawnOffset = 0;

		private static uint __PanelSize = 0;

		private static uint __PanelMesh = 0;

		private static uint __EditorUISize = 0;

		private static uint __bHideWindowHandles = 0;

		private static uint __bMaskOutWidgetBackground = 0;

		private static uint __bNoCloseButton = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}