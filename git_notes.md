# Studying how to git good.
#### R Jansen

_(note)_<br>
_This is written in the context of a solo dev wanting to make a local repo, and then later using a remote repo._
### starting a repository
- you can start git repositories in any folder using `git init`. Note that this is an exclusively local repository.
- `git status` will show status of the git. Untracked files, pending commits, etc.
- in the case of cloning an existing repo from GitHub or similar remote repos, the folder you clone into will ofcourse automatically be a git repo.

### adding files
- files to be added to the git repository should be "moved"/added to the staging area<br>
`git add <files|dirs>` will achieve this (for multiple files too): `git add Form1.cs Enum.cs`
- these staged files can then be seen in `git status` as staged
<br><br>
- next the staged items should be committed to the repo using `git commit`. (this will open vim for you to specify a message)
- _(note) using git commit should be viewed similarly to pressing ctrl+s on your keyboard. You're essentially "saving" your changes._ 
- alternatively, you can use the `-m` flag to set the message in the command: `git commit -m "<message>"`
- `git status` will now show no pending commits.
- `git log` shows a history of commits

### rolling back
- using `git checkout <commit-hash>` we can roll back to a previous commit.
- this will put us on a different branch.

### branches
- branches can be perceived as a timeline of project commits. these branches run in parallel.
- this is useful for adding new/experimental features that we want to keep separate of the main version (**master branch**) for the time being.
- we can create a new branch using `git branch <branch-name>`
- alternatively, we can use the -b flag to specify that we're creating a new branch: `git branch -b <branch-name>` (good practice for remote repositories)
- and use `git branch` to list the current existing branches.
- we then switch to a branch using `git checkout <branch-name>`
- committing will always commit to the current branch you are "checked out" to.
- if we want to merge changes made in a branch into our master branch we can use<br>
  `git merge <target-branch>` -> where target branch is the branch we want to merge ***from***.


### collaboration
***THESE 2 POINTS ARE ONLY VALID IF WE HAVE USED `git clone` TO GET ACCESS TO THE REPO. NOT IF WE'RE THE ONES MAKING THE REPO!***
- if we want to update our online repository with our latest commit we can "push to"/update the remote repository, if we're using one, using `git push`
- if we want to retrieve the latest commit from the repository, we can `git pull`
 <br>
***
  _Going a bit more in depth, we can talk about the work flow for an online repository._
1. Create a local repo, and add/commit as you please.
2. Go to GitHub (or a similar tool like GitLab) and make a new repository.
3. Connect your local repo to the GitHub repo ("adding a remote").
4. "Push" your files up to GitHub using the new remote.
5. "Pull" remote files/commits to your local repo.
<br><br>

##### 1. Creating a local repo
We should already know how to do this.
We initialize any dir as a repository using `git init`.
We can then add to this repo using `git add` and `git commit`, as described earlier.

##### 2. Creating a GitHub repository
This is also very straight forward. Simply go to GitHub or any similar tool online, and create your repository there.

##### 3. Adding a remote
We now have to connect our local repository to GitHub. We achieve this by adding a remote (a sort of "label") to our local repo.
We can do this by first getting the `.git` url of our repository. This can usually be found on the main page of our repository under a big "clone" or "code" button.
It should look something like https://github.com/person/repository_name.git<br>
We can now add this remote to our repo using `git remote`:<br>
- `git remote add <remote-name> <url>` will add a new remote to our repo. The name can be anything, a bit like a variable for a URL, but should usually be "origin" (by convention).
- `git remote -v` (verbose) will list all our remotes as urls.

##### 4. Pushing
We can now use `git push -u <remote-name> <branch>` to push our commits to the remote repo.<br>
The -u flag creates a sort of "tracker" on the remote branch, that links the remote branch to your local branch of the same name, thus there will be no need for specifying this specific branch anymore when pushing commits on it.<br>
***!!HOWEVER!!*** -- It is good practice to still use `git push -u <remote-name> <branch>` as this way you are always intentional about what branch you are pushing to. <br><br>
By default, `git push` will push to remote-name: origin.<br>
Default remote-name can be set in the config (in the .git dir, or through config commands _(which i will not get in to here. It's an easy google)_)<br><br>
To clarify. after we make our _initial_ push to our remote repo using ex: `git push -u origin master`("origin" here is the name we gave our remote earlier), we can from here forward push to master using `git push`.

##### 5. Pulling
To get files/commits that are on the remote repo into your repository, we need to pull them into our repository. This is basically the inverse of pushing and has similar syntax.<br>
`git pull <remote-branch> <branch>`<br>

##### Cloning
When you want to "pull" a remote repo without having worked in the repository before (for example, as a collaborator) we use `git clone <url>`<br>
Here we use the same URL we would use for adding a remote to an existing local repo.<br>
This will essentially copy the entire repo over to your local storage (whereever you are executing the command), and let you work in it as you would in any git repo (so long as you are a collaborator).
