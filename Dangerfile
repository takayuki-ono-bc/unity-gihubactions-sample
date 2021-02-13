has_unchecked_tasks = github.pr_body =~ /^\s*- \[ \] /
failure 'There are unchecked tasks. :white_medium_square:' if has_unchecked_tasks

warn "We cannot handle the scale of this PR" if git.lines_of_code > 5
