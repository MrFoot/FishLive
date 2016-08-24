using System;
using Soulgame.StateManagement;

public abstract class BaseCharacterState : StateManager<BaseCharacterState, CharacterAction>.State
{
	public virtual string Tag
	{
		get
		{
			return base.GetType().Name;
		}
	}
	
    public CharacterStateManager CharacterStateManager
	{
		get;
		private set;
	}

    protected BaseCharacterState(CharacterStateManager stateManager)
        : base(stateManager)
	{
        this.CharacterStateManager = stateManager;
	}

    public override void OnPreExit(BaseCharacterState nextState, object data)
    {
        base.OnPreExit(nextState, data);
        if (nextState != null)
        {
        }

    }

    public override BaseCharacterState OnPreEnter(BaseCharacterState previousState, object data)
    {
        base.OnPreEnter(previousState, data);
        if (previousState != null)
        {
        }
        return this;
    }

    public override void OnEnter(BaseCharacterState previousState, object data)
	{
	}

    public override void OnExit(BaseCharacterState nextState, object data)
	{
	}
		
    //���ﴦ��һЩ�ڸ���������Ҫ�õ����¼����� ��������򣬻��Ҹ��µ�
    public override void OnAction(CharacterAction characterAction, object data)
	{
        switch (characterAction)
        {

            default:
                
                break;
        }
	}

	public override void OnAppResume ()
	{
		base.OnAppResume ();
	}

	public override void OnAppPause ()
	{
		base.OnAppPause ();
	}

	public override void OnUpdate ()
	{
		base.OnUpdate ();
	}



}


