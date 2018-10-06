﻿using System;
using System.Collections.Generic;
using System.Linq;
using StackOverflowClone.DomainModels;

namespace StackOverflowClone.Repositories
{
    public interface IVotesRepository
    {
        void UpdateVote(int aid, int uid, int value);

    }
    public class VotesRepository : IVotesRepository
    {
        StackOverflowDbContext db;

        public VotesRepository()
        {
            db = new StackOverflowDbContext();
        }
        public void UpdateVote(int aid,int uid,int value)
        {
            int updateValue;
            if (value > 0) updateValue = 1;
            else if (value < 0) updateValue = -1;
            else updateValue = 0;
            Vote vote = db.Votes.Where(temp => temp.AnswerID == aid && temp.UserID == uid).FirstOrDefault();
            if(vote!=null)
            {
                vote.VoteValue = updateValue;
            }
            else
            {
                Vote newVote = new Vote()
                {
                    AnswerID = aid,
                    VoteValue = updateValue
                };
                db.Votes.Add(newVote);
            }
            db.SaveChanges();
        }
    }
}
