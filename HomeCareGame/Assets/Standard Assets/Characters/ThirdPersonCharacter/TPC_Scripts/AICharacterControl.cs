using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    //[RequireComponent(typeof (NavMeshAgent))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform[] target;                                    // target to aim for
        private int index = 0;
        private GameObject floor;
        //public Inventory inventory; får se om det blir nødvendig



        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;
           // agent.autoBraking = false;

            GotoNextPoint();

        }

        void GotoNextPoint()
        {
            // Returns if no points have been set up
            if (target.Length == 0)
                return;

            // Set the agent to go to the currently selected destination.
            agent.destination = target[index].position;

            // Choose the next point in the array as the destination,
            // cycling to the start if necessary.
            index = (index + 1) % target.Length;
        }



        private void Update()
        {

            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GotoNextPoint();

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, false, false);
            else
                character.Move(Vector3.zero, false, false);
        }


       // public void SetTarget(Transform[] target)
       // {
       //     this.target = target;
       // }
    }
}
