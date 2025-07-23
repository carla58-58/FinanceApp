# 🚀 Free Deployment Guide - Render.com

## Quick Deployment Steps

### 1. **Push to GitHub**
```bash
git add .
git commit -m "Convert to SQLite for free deployment"
git push origin main
```

### 2. **Deploy on Render**
1. Go to [render.com](https://render.com) and sign up/login
2. Click **"New"** → **"Web Service"**
3. Connect your GitHub repository
4. Select your `FinanceApp` repository
5. Render will automatically detect the `render.yaml` file
6. Click **"Deploy"**

### 3. **That's it!** 🎉
- Your app will be live at `https://your-app-name.onrender.com`
- SQLite database is included and persistent
- **Completely free!**

## What's Included

✅ **Dockerfile** - For containerized deployment  
✅ **render.yaml** - Automatic Render configuration with persistent storage  
✅ **SQLite Database** - Stored on persistent disk (data survives deployments)  
✅ **Production Settings** - Ready for deployment  
✅ **Database Migrations** - Automatic database setup  

## Data Persistence

🎯 **Important**: Your database is now configured with **persistent storage**:
- Database file: `/app/data/financeApp.db`
- Mounted on: **Render persistent disk**
- **Data survives**: Deployments, restarts, and updates
- **Backup**: Render handles disk backups automatically  

## Alternative Free Hosting

If you prefer other platforms:

- **Railway.app** - Import from GitHub, auto-deploy
- **Heroku** - Free tier (with some limitations)
- **Azure App Service** - Free F1 tier (limited)

## Cost Breakdown

- **Hosting**: FREE (Render free tier)
- **Database**: FREE (SQLite file-based)
- **Domain**: FREE (render.com subdomain)
- **SSL**: FREE (included)

**Total: $0/month** 💰

## Support

If you encounter any issues:
1. Check the Render logs in the dashboard
2. Ensure your GitHub repo is public or connected properly
3. Verify the Dockerfile builds locally: `docker build -t financeapp .`
