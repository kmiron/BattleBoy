
#include "Globals.h"

void Player::update(float dt)
{
	creditsTime += dt;
	if (creditsRate <= creditsTime)
	{
		credits += creditsIncrement;
		creditsTime -= creditsRate;
	}
}

void Player::init()
{
	credits = 0;
	creditsTime = 0.0f;
	creditsRate = 1.0f;
	creditsIncrement = 60;
	bIsAI = false;
}
