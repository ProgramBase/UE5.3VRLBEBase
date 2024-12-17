using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackRoot")]
	public partial class UNiagaraStackRoot : UNiagaraStackEntry, IStaticClass
	{
		public UNiagaraStackSystemPropertiesGroup SystemPropertiesGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SystemPropertiesGroup, __ReturnBuffer);

					return *(UNiagaraStackSystemPropertiesGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SystemPropertiesGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackSystemUserParametersGroup SystemUserParametersGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SystemUserParametersGroup, __ReturnBuffer);

					return *(UNiagaraStackSystemUserParametersGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SystemUserParametersGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup SystemSpawnGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SystemSpawnGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SystemSpawnGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup SystemUpdateGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SystemUpdateGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SystemUpdateGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackEmitterPropertiesGroup EmitterPropertiesGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterPropertiesGroup, __ReturnBuffer);

					return *(UNiagaraStackEmitterPropertiesGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterPropertiesGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackEmitterSummaryGroup EmitterSummaryGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterSummaryGroup, __ReturnBuffer);

					return *(UNiagaraStackEmitterSummaryGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterSummaryGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup EmitterSpawnGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup EmitterUpdateGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterUpdateGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterUpdateGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup ParticleSpawnGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleSpawnGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleSpawnGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackScriptItemGroup ParticleUpdateGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleUpdateGroup, __ReturnBuffer);

					return *(UNiagaraStackScriptItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleUpdateGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackRenderItemGroup RenderGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderGroup, __ReturnBuffer);

					return *(UNiagaraStackRenderItemGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderGroup, __InBuffer);
				}
			}
		}

		public UNiagaraStackCommentCollection CommentCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CommentCollection, __ReturnBuffer);

					return *(UNiagaraStackCommentCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CommentCollection, __InBuffer);
				}
			}
		}

		public UNiagaraStackSummaryViewCollapseButton SummaryCollapseButton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryCollapseButton, __ReturnBuffer);

					return *(UNiagaraStackSummaryViewCollapseButton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryCollapseButton, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackRoot");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SystemPropertiesGroup = 0;

		private static uint __SystemUserParametersGroup = 0;

		private static uint __SystemSpawnGroup = 0;

		private static uint __SystemUpdateGroup = 0;

		private static uint __EmitterPropertiesGroup = 0;

		private static uint __EmitterSummaryGroup = 0;

		private static uint __EmitterSpawnGroup = 0;

		private static uint __EmitterUpdateGroup = 0;

		private static uint __ParticleSpawnGroup = 0;

		private static uint __ParticleUpdateGroup = 0;

		private static uint __RenderGroup = 0;

		private static uint __CommentCollection = 0;

		private static uint __SummaryCollapseButton = 0;
	}
}